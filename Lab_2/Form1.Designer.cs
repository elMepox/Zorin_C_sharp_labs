namespace Lab_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dirPathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectDirButton = new System.Windows.Forms.Button();
            this.selectFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.FilesListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FileAtribCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.filesCreatedErlierListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dirPathTextBox
            // 
            this.dirPathTextBox.Enabled = false;
            this.dirPathTextBox.Location = new System.Drawing.Point(12, 29);
            this.dirPathTextBox.Name = "dirPathTextBox";
            this.dirPathTextBox.Size = new System.Drawing.Size(617, 22);
            this.dirPathTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Путь к папке";
            // 
            // selectDirButton
            // 
            this.selectDirButton.Location = new System.Drawing.Point(635, 29);
            this.selectDirButton.Name = "selectDirButton";
            this.selectDirButton.Size = new System.Drawing.Size(153, 23);
            this.selectDirButton.TabIndex = 2;
            this.selectDirButton.Text = "Выбрать папку";
            this.selectDirButton.UseVisualStyleBackColor = true;
            this.selectDirButton.Click += new System.EventHandler(this.selectDirButton_Click);
            // 
            // FilesListBox
            // 
            this.FilesListBox.FormattingEnabled = true;
            this.FilesListBox.ItemHeight = 16;
            this.FilesListBox.Location = new System.Drawing.Point(12, 74);
            this.FilesListBox.Name = "FilesListBox";
            this.FilesListBox.Size = new System.Drawing.Size(381, 132);
            this.FilesListBox.TabIndex = 3;
            this.FilesListBox.SelectedIndexChanged += new System.EventHandler(this.FilesListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Список файлов";
            // 
            // FileAtribCheckedListBox
            // 
            this.FileAtribCheckedListBox.FormattingEnabled = true;
            this.FileAtribCheckedListBox.Location = new System.Drawing.Point(399, 74);
            this.FileAtribCheckedListBox.Name = "FileAtribCheckedListBox";
            this.FileAtribCheckedListBox.Size = new System.Drawing.Size(389, 293);
            this.FileAtribCheckedListBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Список атрибутов";
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(596, 373);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(192, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Сохранить изменения";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Enabled = false;
            this.cancelButton.Location = new System.Drawing.Point(399, 373);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(191, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Отменить изменения";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // filesCreatedErlierListBox
            // 
            this.filesCreatedErlierListBox.Enabled = false;
            this.filesCreatedErlierListBox.FormattingEnabled = true;
            this.filesCreatedErlierListBox.ItemHeight = 16;
            this.filesCreatedErlierListBox.Location = new System.Drawing.Point(15, 235);
            this.filesCreatedErlierListBox.Name = "filesCreatedErlierListBox";
            this.filesCreatedErlierListBox.Size = new System.Drawing.Size(381, 132);
            this.filesCreatedErlierListBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(366, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Список файлов созданных раньше выбранного файла";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 414);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.filesCreatedErlierListBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FileAtribCheckedListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FilesListBox);
            this.Controls.Add(this.selectDirButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dirPathTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dirPathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selectDirButton;
        private System.Windows.Forms.FolderBrowserDialog selectFolderBrowserDialog;
        private System.Windows.Forms.ListBox FilesListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox FileAtribCheckedListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ListBox filesCreatedErlierListBox;
        private System.Windows.Forms.Label label4;
    }
}

