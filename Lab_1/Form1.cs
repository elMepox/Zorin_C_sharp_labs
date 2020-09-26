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

namespace Lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            onStart();
        }
        
        private void onStart()
        {
            //Получение списка логических дисков компьютера
            DriveInfo[] drives = DriveInfo.GetDrives();
            //Проходим в цикле по списку логических дисков
            foreach(DriveInfo drive in drives)
            {
                //Добавляем в TreeView узлы с названиями логических дисков
                logicalDisksTreeView.Nodes.Add(drive.Name);
            }
            //проверяем наличие логических дисков
            if(logicalDisksTreeView.Nodes.Count > 0)
            {
                //помечаем первый логический диск для работы (пользователь может изменить выбранный лог. диск)
                logicalDisksTreeView.Nodes[0].Checked = true;
            }
            
        }
        //Событие, вызываемое при нажатии на чекбокс
        private void logicalDisksTreeView_AfterCheck(object sender, TreeViewEventArgs e)
        {
            //Данная проверка необходима чтобы удостовериться что данное событие было вызвано пользователем
            if(e.Action != TreeViewAction.Unknown)
            {
                //Вызываем очистку галочек с чекбоксов TreeView
                uncheckAllNodesInTreeView(logicalDisksTreeView);
                //Помечаем выбранный пользователем чекбокс как нажатый
                e.Node.Checked = true;
            }
        }
        //Функция, удаляющая все отметки с узлов treeView (нужна для снятия галочеки с уже выбранного логического диска)
        private void uncheckAllNodesInTreeView(TreeView treeView)
        {
            //Проходим по списку узлов в TreeView
            foreach(TreeNode treeNode in treeView.Nodes)
            {
                //убираем галочку с текущего узла
                treeNode.Checked = false;
            }
        }
        //Функция, вызываемая при нажатии на кнопку "Искать"
        private void searchButton_Click(object sender, EventArgs e)
        {
            //Проверяем ввел ли пользователь имя файла для поиска
            if(searchFileNameTextBox.Text != "")
            {
                //Очищаем поле вывода
                searchFilesPathsListBox.Items.Clear();
                //Запускаем процесс поиска файлов в фоновом режиме. 
                backgroundWorker.RunWorkerAsync();
                //Делаем кнопку поиска недействительной
                searchButton.Enabled = false;
                //Делаем прогрессбар видимым и делаем его доступным
                progressBar.Enabled = true;
                progressBar.Visible = true;
            }
            //Если фоновый процесс запущен 
            while (backgroundWorker.IsBusy)
            {
                //Принуждаем форму обрабатывать события
                Application.DoEvents();
            }
            
        }
        /**scanDirs(string dirPath, string searchFileName)
         * Функция рекурсивного поиска файла в указанной дерриктории (при первом вызове начинате поиск в указанном лог. диске)
         * dirPath - путь к папке, из которой происходит поиск
         * searchFileName - имя искомого файла**/
        private void scanDirs(string dirPath, string searchFileName)
        {
            //Блок try здесь необходим т.к. программа может попытаться открыть файл, к которому у неё нет доступа
            try
            {
                //По списку файлов из дерриктории
                foreach (string filePath in Directory.GetFiles(dirPath))
                {
                    //Получаем объект с информацией о файле 
                    FileInfo fileInfo = new FileInfo(filePath);
                    //Сверяем имя текущего файла с именем искомого файла
                    if (fileInfo.Name.ToLower().Split('.')[0] == searchFileName.ToLower())
                        //Вызываем функцию добавления подходящего файла в listBox с результатом поиска
                        addFileNameInListBox(filePath);
                }
            }
            catch
            {

            }
            try
            {
                //Проходим по списку папок
                foreach (string path in Directory.GetDirectories(dirPath))
                {
                    //Для каждой папки рекурсивно вызываем функцию поиска файла
                    scanDirs(path, searchFileName);
                }
            }
            catch
            {

            }
            
        }
        //Функция добавления элемента в listBox конечного результата
        private void addFileNameInListBox(string filePath)
        {
            //Добавляем из потока, в котором была вызвана эта функция, путь к подходящему по названию файлу в listBox
            searchFilesPathsListBox.Invoke((Action)(() =>
            {
                searchFilesPathsListBox.Items.Add(filePath);

            }));
        }
        //Функция, для получения из treeView отмеченного узла
        private TreeNode getCheckedNode(TreeView treeView)
        {
            //Временная переменная
            TreeNode temp = null;
            //Проходим по списку узлов
            foreach(TreeNode treeNode in treeView.Nodes)
            {
                //Если есть отмеченный галочкой
                if (treeNode.Checked)
                {
                    //Сохраняем его в переменную temp
                    temp = treeNode;
                    //Выходим из списка
                    break;
                }
            }
            //Возвращаем найденный узел
            return temp;
        }
        //Событие, вызываемое при начале работы фонового процесса поиска (по сути - тело процесса)
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //Получаем путь выбранного лог. диска
            string path = getCheckedNode(logicalDisksTreeView).Text;
            //Начинаем поиск
            scanDirs(path, searchFileNameTextBox.Text);
        }
        //Событие, вызываемое при завершении фонового процесса поиска
        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Делаем кнопку поиска вновь доступной
            searchButton.Enabled = true;
            //Прячем и делаем недоступным прогрессбар
            progressBar.Enabled = false;
            progressBar.Visible = false;
        }
    }
}
