using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Событие, вызываемое при нажатии на кнопку "Выбрать папку"
        private void selectDirButton_Click(object sender, EventArgs e)
        {
            //Получаем результат выбора пользователя
            DialogResult result = selectFolderBrowserDialog.ShowDialog();
            //Если результат корректен
            if(result == DialogResult.OK && !string.IsNullOrWhiteSpace(selectFolderBrowserDialog.SelectedPath)) { }
            {
                //Очищаем все списки
                filesCreatedErlierListBox.Items.Clear();
                FileAtribCheckedListBox.Items.Clear();
                FilesListBox.Items.Clear();
                //Деактивируем кнопки
                saveButton.Enabled = false;
                cancelButton.Enabled = false;
                //Выводим путь к выбранной папке
                dirPathTextBox.Text = selectFolderBrowserDialog.SelectedPath;
                //Получаем список файлов в папке
                string[] files = Directory.GetFiles(selectFolderBrowserDialog.SelectedPath);
                //Выводим список файлов текущей папки
                FilesListBox.Items.Clear();
                FilesListBox.Items.AddRange(files);
            }
        }
        //Событие вызываемое при выборе файла из списка
        private void FilesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Активируем кнопки
            saveButton.Enabled = true;
            cancelButton.Enabled = true;
            //Получаем путь к выбранному файлу
            string selectedFile = FilesListBox.SelectedItem.ToString();
            //Получаем путь к текущей папке
            string currentDir = dirPathTextBox.Text;
            //Получаем атрибуты выбанного файла
            FileAttributes selectedFileAttrib = File.GetAttributes(selectedFile);
            //очищаем списки атрибутов и файлов, что были созданы раньше
            FileAtribCheckedListBox.Items.Clear();
            filesCreatedErlierListBox.Items.Clear();
            //Выводим список файлов, что созданы раньше выбранного файла
            filesCreatedErlierListBox.Items.AddRange(getFilesCreatedErlier(currentDir, selectedFile));
            
            //Далее идет код, выводящий список атрибутов и помечает те, что присутствуют у файла

            FileAtribCheckedListBox.Items.Add("Только для чтения");
            if (selectedFileAttrib.HasFlag(FileAttributes.ReadOnly))
            {
                FileAtribCheckedListBox.SetItemChecked(0, true);
            }
            else
            {
                FileAtribCheckedListBox.SetItemChecked(0, false);
            }


            FileAtribCheckedListBox.Items.Add("Скрытый");
            if (selectedFileAttrib.HasFlag(FileAttributes.Hidden))
            {
                FileAtribCheckedListBox.SetItemChecked(1, true);
            }
            else
            {
                FileAtribCheckedListBox.SetItemChecked(1, false);
            }


            FileAtribCheckedListBox.Items.Add("Системный");
            if (selectedFileAttrib.HasFlag(FileAttributes.System))
            {
                FileAtribCheckedListBox.SetItemChecked(2, true);
            }
            else
            {
                FileAtribCheckedListBox.SetItemChecked(2, false);
            }
        }
        //Событие, вызываемое при нажатии на кнопку "Сохранить"
        private void saveButton_Click(object sender, EventArgs e)
        {
            //Получаем путь к выбранному файлу 
            string selectedFile = FilesListBox.SelectedItem.ToString();
            //Получаем список атрибутов
            FileAttributes selectedFileAttrib = File.GetAttributes(selectedFile);
            
            //Далее идет код, добавляющий/удаляющий атрибуты файлу, согласно выбору пользователя (отметки в чекбосах)
            
            //Получаем информацию о том, выбран ли атрибут для добавления
            if (FileAtribCheckedListBox.GetItemChecked(0))
            {
                //Если выбран, то добавляем его в перечень атрибутов файла
                selectedFileAttrib = AddAttribute(selectedFileAttrib, FileAttributes.ReadOnly);
            }
            //Иначе проверяем присутсвует ли атрибут для удаления у файла
            else if(selectedFileAttrib.HasFlag(FileAttributes.ReadOnly))
            {
                //Если да, то удаляем атрибут
                selectedFileAttrib = RemoveAttribute(selectedFileAttrib, FileAttributes.ReadOnly);
            }
            
            //Далее также как и с первым атрибутом
            
            if (FileAtribCheckedListBox.GetItemChecked(1))
            {
                selectedFileAttrib = AddAttribute(selectedFileAttrib, FileAttributes.Hidden);
            }
            else if (selectedFileAttrib.HasFlag(FileAttributes.Hidden))
            {
                selectedFileAttrib = RemoveAttribute(selectedFileAttrib, FileAttributes.Hidden);
            }
            
            
            if (FileAtribCheckedListBox.GetItemChecked(2))
            {
                selectedFileAttrib = AddAttribute(selectedFileAttrib, FileAttributes.System);
            }
            else if(selectedFileAttrib.HasFlag(FileAttributes.System))
            {
                selectedFileAttrib = RemoveAttribute(selectedFileAttrib, FileAttributes.System);
            }

            //Устанавливаем полученный перечень атрибутов файлу
            File.SetAttributes(selectedFile, selectedFileAttrib);
        }

        //Событие, вызываемое при нажатии на клавишу "отмена"
        private void cancelButton_Click(object sender, EventArgs e)
        {
            //получаем путь к выбранному файлу
            string selectedFile = FilesListBox.SelectedItem.ToString();
            //Получаем перечень атрибутов выбранного файла
            FileAttributes selectedFileAttrib = File.GetAttributes(selectedFile);
            //Очищаем список атрибутов
            FileAtribCheckedListBox.Items.Clear();
            //Далее идет код, выводящий список атрибутов и помечает те, что присутствуют у файла

            FileAtribCheckedListBox.Items.Add("Только для чтения");
            if (selectedFileAttrib.HasFlag(FileAttributes.ReadOnly))
            {
                FileAtribCheckedListBox.SetItemChecked(0, true);
            }
            else
            {
                FileAtribCheckedListBox.SetItemChecked(0, false);
            }


            FileAtribCheckedListBox.Items.Add("Скрытый");
            if (selectedFileAttrib.HasFlag(FileAttributes.Hidden))
            {
                FileAtribCheckedListBox.SetItemChecked(1, true);
            }
            else
            {
                FileAtribCheckedListBox.SetItemChecked(1, false);
            }


            FileAtribCheckedListBox.Items.Add("Системный");
            if (selectedFileAttrib.HasFlag(FileAttributes.System))
            {
                FileAtribCheckedListBox.SetItemChecked(2, true);
            }
            else
            {
                FileAtribCheckedListBox.SetItemChecked(2, false);
            }
        }

        /*Функция удаляющая атрибут из переданного перечня атрибутов файла
        Аргументы:
        FileAttributes attributes - перечень атрибутов файла
        FileAttributes attributesToRemove - перечень атрибутов для удаления
        возвращает:
        Перечень атрибутов файла без тех атрибутов, что были выбраны для удаления
        */
        private static FileAttributes RemoveAttribute(FileAttributes attributes, FileAttributes attributesToRemove)
        {

            return attributes & ~attributesToRemove;
        }
        /*Функция добавляющая атрибут в перечнь атрибутов файла
        Аргументы:
        FileAttributes attributes - перечень атрибутов файла
        FileAttributes attributesToAdd - перечень атрибутов для добавления
        возвращает:
        Перечень атрибутов файла с тем перечнем атрибутов, что были переданы для добавления
        */
        private static FileAttributes AddAttribute(FileAttributes attributes, FileAttributes attributesToAdd)
        {
            return attributes | attributesToAdd;
        }

        /*Функция получает список файлов которые были созданы раньше выбранного файла 
        Аргументы:
        string dirPath - путь к папке, в которой происходит поиск
        string filePath - путь к выбранному файлу 
        возвращает:
        Список файлов, что были созданы раньше выбранного файла
        */
        private string[] getFilesCreatedErlier(string dirPath, string filePath)
        {
            //Список, хранящий результат вычеслений
            List<string> result = new List<string>();
            //Проходим в цикле по всем файлам из папки
            foreach(string file in Directory.GetFiles(dirPath))
            {
                //Если текущий файл был создан раньше чем выбранный файл
                if (File.GetCreationTime(file) < File.GetCreationTime(filePath))
                {
                    //Заносим его в результирующий список
                    result.Add(file);
                }
            }
            //Возвращаем массив 
            return result.ToArray();
        }

    }
}
