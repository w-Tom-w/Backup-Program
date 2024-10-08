namespace Backup_Program.GUI
{
    partial class FirstCopyGUI
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuPnl = new Panel();
            btnSelectDir = new Button();
            btnSelectFiles = new Button();
            grpBxSettingsOfCopy = new GroupBox();
            btnSelectBackupFolder = new Button();
            btnSelectFilesOrDir = new Button();
            dataGridView1 = new DataGridView();
            btnCopyFiles = new Button();
            lblSpecifyNumberOfDays = new Label();
            dayCounter = new NumericUpDown();
            lblExtensions = new Label();
            txtBxExtensions = new TextBox();
            menuPnl.SuspendLayout();
            grpBxSettingsOfCopy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dayCounter).BeginInit();
            SuspendLayout();
            // 
            // menuPnl
            // 
            menuPnl.BorderStyle = BorderStyle.FixedSingle;
            menuPnl.Controls.Add(btnSelectDir);
            menuPnl.Controls.Add(btnSelectFiles);
            menuPnl.Dock = DockStyle.Top;
            menuPnl.Location = new Point(0, 0);
            menuPnl.Name = "menuPnl";
            menuPnl.Size = new Size(725, 32);
            menuPnl.TabIndex = 1;
            // 
            // btnSelectDir
            // 
            btnSelectDir.Dock = DockStyle.Left;
            btnSelectDir.FlatAppearance.BorderSize = 0;
            btnSelectDir.FlatStyle = FlatStyle.Flat;
            btnSelectDir.Location = new Point(101, 0);
            btnSelectDir.Name = "btnSelectDir";
            btnSelectDir.Size = new Size(101, 30);
            btnSelectDir.TabIndex = 1;
            btnSelectDir.Text = "Директорию";
            btnSelectDir.UseVisualStyleBackColor = true;
            // 
            // btnSelectFiles
            // 
            btnSelectFiles.Dock = DockStyle.Left;
            btnSelectFiles.FlatAppearance.BorderSize = 0;
            btnSelectFiles.FlatStyle = FlatStyle.Flat;
            btnSelectFiles.Location = new Point(0, 0);
            btnSelectFiles.Name = "btnSelectFiles";
            btnSelectFiles.Size = new Size(101, 30);
            btnSelectFiles.TabIndex = 0;
            btnSelectFiles.Text = "Файлы";
            btnSelectFiles.UseVisualStyleBackColor = true;
            // 
            // grpBxSettingsOfCopy
            // 
            grpBxSettingsOfCopy.Controls.Add(txtBxExtensions);
            grpBxSettingsOfCopy.Controls.Add(lblExtensions);
            grpBxSettingsOfCopy.Controls.Add(dayCounter);
            grpBxSettingsOfCopy.Controls.Add(lblSpecifyNumberOfDays);
            grpBxSettingsOfCopy.Controls.Add(btnCopyFiles);
            grpBxSettingsOfCopy.Controls.Add(btnSelectBackupFolder);
            grpBxSettingsOfCopy.Controls.Add(btnSelectFilesOrDir);
            grpBxSettingsOfCopy.Dock = DockStyle.Bottom;
            grpBxSettingsOfCopy.Location = new Point(0, 229);
            grpBxSettingsOfCopy.Name = "grpBxSettingsOfCopy";
            grpBxSettingsOfCopy.Size = new Size(725, 190);
            grpBxSettingsOfCopy.TabIndex = 2;
            grpBxSettingsOfCopy.TabStop = false;
            grpBxSettingsOfCopy.Text = "Параметры копирования";
            // 
            // btnSelectBackupFolder
            // 
            btnSelectBackupFolder.FlatStyle = FlatStyle.Flat;
            btnSelectBackupFolder.Location = new Point(116, 20);
            btnSelectBackupFolder.Name = "btnSelectBackupFolder";
            btnSelectBackupFolder.Size = new Size(104, 28);
            btnSelectBackupFolder.TabIndex = 0;
            btnSelectBackupFolder.Text = "Куда";
            btnSelectBackupFolder.UseVisualStyleBackColor = true;
            // 
            // btnSelectFilesOrDir
            // 
            btnSelectFilesOrDir.FlatStyle = FlatStyle.Flat;
            btnSelectFilesOrDir.Location = new Point(6, 20);
            btnSelectFilesOrDir.Name = "btnSelectFilesOrDir";
            btnSelectFilesOrDir.Size = new Size(104, 28);
            btnSelectFilesOrDir.TabIndex = 0;
            btnSelectFilesOrDir.Text = "Что";
            btnSelectFilesOrDir.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(725, 191);
            dataGridView1.TabIndex = 3;
            // 
            // btnCopyFiles
            // 
            btnCopyFiles.FlatStyle = FlatStyle.Flat;
            btnCopyFiles.Location = new Point(615, 156);
            btnCopyFiles.Name = "btnCopyFiles";
            btnCopyFiles.Size = new Size(104, 28);
            btnCopyFiles.TabIndex = 1;
            btnCopyFiles.Text = "Копировать";
            btnCopyFiles.UseVisualStyleBackColor = true;
            // 
            // lblSpecifyNumberOfDays
            // 
            lblSpecifyNumberOfDays.AutoSize = true;
            lblSpecifyNumberOfDays.Location = new Point(6, 61);
            lblSpecifyNumberOfDays.Name = "lblSpecifyNumberOfDays";
            lblSpecifyNumberOfDays.Size = new Size(252, 15);
            lblSpecifyNumberOfDays.TabIndex = 2;
            lblSpecifyNumberOfDays.Text = "Укажите за последнии сколько дней";
            // 
            // dayCounter
            // 
            dayCounter.Location = new Point(278, 59);
            dayCounter.Name = "dayCounter";
            dayCounter.Size = new Size(51, 21);
            dayCounter.TabIndex = 3;
            // 
            // lblExtensions
            // 
            lblExtensions.AutoSize = true;
            lblExtensions.Location = new Point(6, 93);
            lblExtensions.Name = "lblExtensions";
            lblExtensions.Size = new Size(145, 15);
            lblExtensions.TabIndex = 4;
            lblExtensions.Text = "Расширения файлов";
            // 
            // txtBxExtensions
            // 
            txtBxExtensions.Location = new Point(158, 93);
            txtBxExtensions.Name = "txtBxExtensions";
            txtBxExtensions.Size = new Size(171, 21);
            txtBxExtensions.TabIndex = 5;
            // 
            // FirstCopyGUI
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(grpBxSettingsOfCopy);
            Controls.Add(menuPnl);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            Name = "FirstCopyGUI";
            Size = new Size(725, 419);
            Load += ArbitraryCopyGUI_Load;
            menuPnl.ResumeLayout(false);
            grpBxSettingsOfCopy.ResumeLayout(false);
            grpBxSettingsOfCopy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dayCounter).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel menuPnl;
        private Button btnSelectFiles;
        private Button btnSelectDir;
        private GroupBox grpBxSettingsOfCopy;
        private DataGridView dataGridView1;
        private Button btnSelectFilesOrDir;
        private Button btnSelectBackupFolder;
        private Button btnCopyFiles;
        private Label lblSpecifyNumberOfDays;
        private NumericUpDown dayCounter;
        private Label lblExtensions;
        private TextBox txtBxExtensions;
    }
}
