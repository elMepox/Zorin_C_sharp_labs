namespace Lab_1
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
            this.logicalDisksTreeView = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.searchFileNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchFilesPathsListBox = new System.Windows.Forms.ListBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // logicalDisksTreeView
            // 
            this.logicalDisksTreeView.CheckBoxes = true;
            this.logicalDisksTreeView.Location = new System.Drawing.Point(12, 29);
            this.logicalDisksTreeView.Name = "logicalDisksTreeView";
            this.logicalDisksTreeView.Size = new System.Drawing.Size(136, 480);
            this.logicalDisksTreeView.TabIndex = 0;
            this.logicalDisksTreeView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.logicalDisksTreeView_AfterCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логичские диски:";
            // 
            // searchFileNameTextBox
            // 
            this.searchFileNameTextBox.Location = new System.Drawing.Point(154, 29);
            this.searchFileNameTextBox.Name = "searchFileNameTextBox";
            this.searchFileNameTextBox.Size = new System.Drawing.Size(346, 22);
            this.searchFileNameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя искомого файла:";
            // 
            // searchFilesPathsListBox
            // 
            this.searchFilesPathsListBox.FormattingEnabled = true;
            this.searchFilesPathsListBox.ItemHeight = 16;
            this.searchFilesPathsListBox.Location = new System.Drawing.Point(155, 90);
            this.searchFilesPathsListBox.Name = "searchFilesPathsListBox";
            this.searchFilesPathsListBox.Size = new System.Drawing.Size(822, 388);
            this.searchFilesPathsListBox.TabIndex = 4;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(506, 28);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(122, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Искать";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(155, 486);
            this.progressBar.MarqueeAnimationSpeed = 30;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(822, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 6;
            this.progressBar.Visible = false;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 521);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchFilesPathsListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchFileNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logicalDisksTreeView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView logicalDisksTreeView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchFileNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox searchFilesPathsListBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}

