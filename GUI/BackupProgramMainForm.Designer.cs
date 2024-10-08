using Backup_Program.GUI;

namespace Backup_Program
{
    partial class BackupProgramMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMenu = new Panel();
            btnProgramSettings = new Button();
            btnHelp = new Button();
            btnCurrentTask = new Button();
            btnCopyScheduler = new Button();
            btnArbitraryCopy = new Button();
            pnlContent = new Panel();
            pnlHeader = new Panel();
            lblCurentSection = new Label();
            pnlMenu.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = SystemColors.Control;
            pnlMenu.BorderStyle = BorderStyle.FixedSingle;
            pnlMenu.Controls.Add(btnProgramSettings);
            pnlMenu.Controls.Add(btnHelp);
            pnlMenu.Controls.Add(btnCurrentTask);
            pnlMenu.Controls.Add(btnCopyScheduler);
            pnlMenu.Controls.Add(btnArbitraryCopy);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(189, 450);
            pnlMenu.TabIndex = 0;
            // 
            // btnProgramSettings
            // 
            btnProgramSettings.Dock = DockStyle.Bottom;
            btnProgramSettings.FlatAppearance.BorderSize = 0;
            btnProgramSettings.FlatStyle = FlatStyle.Flat;
            btnProgramSettings.Location = new Point(0, 388);
            btnProgramSettings.Name = "btnProgramSettings";
            btnProgramSettings.Size = new Size(187, 30);
            btnProgramSettings.TabIndex = 4;
            btnProgramSettings.Text = "Настройки";
            btnProgramSettings.UseVisualStyleBackColor = true;
            btnProgramSettings.Click += btnProgramSettings_Click;
            // 
            // btnHelp
            // 
            btnHelp.Dock = DockStyle.Bottom;
            btnHelp.FlatAppearance.BorderSize = 0;
            btnHelp.FlatStyle = FlatStyle.Flat;
            btnHelp.Location = new Point(0, 418);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(187, 30);
            btnHelp.TabIndex = 3;
            btnHelp.Text = "Справка";
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click;
            // 
            // btnCurrentTask
            // 
            btnCurrentTask.Dock = DockStyle.Top;
            btnCurrentTask.FlatAppearance.BorderSize = 0;
            btnCurrentTask.FlatStyle = FlatStyle.Flat;
            btnCurrentTask.Location = new Point(0, 60);
            btnCurrentTask.Name = "btnCurrentTask";
            btnCurrentTask.Size = new Size(187, 30);
            btnCurrentTask.TabIndex = 2;
            btnCurrentTask.Text = "Текущие задачи";
            btnCurrentTask.UseVisualStyleBackColor = true;
            btnCurrentTask.Click += btnCurrentTask_Click;
            // 
            // btnCopyScheduler
            // 
            btnCopyScheduler.Dock = DockStyle.Top;
            btnCopyScheduler.FlatAppearance.BorderSize = 0;
            btnCopyScheduler.FlatStyle = FlatStyle.Flat;
            btnCopyScheduler.Location = new Point(0, 30);
            btnCopyScheduler.Name = "btnCopyScheduler";
            btnCopyScheduler.Size = new Size(187, 30);
            btnCopyScheduler.TabIndex = 1;
            btnCopyScheduler.Text = "Запланировать";
            btnCopyScheduler.UseVisualStyleBackColor = true;
            btnCopyScheduler.Click += btnCopyScheduler_Click;
            // 
            // btnArbitraryCopy
            // 
            btnArbitraryCopy.Dock = DockStyle.Top;
            btnArbitraryCopy.FlatAppearance.BorderSize = 0;
            btnArbitraryCopy.FlatStyle = FlatStyle.Flat;
            btnArbitraryCopy.Location = new Point(0, 0);
            btnArbitraryCopy.Name = "btnArbitraryCopy";
            btnArbitraryCopy.Size = new Size(187, 30);
            btnArbitraryCopy.TabIndex = 0;
            btnArbitraryCopy.Text = "Быстрое копирование";
            btnArbitraryCopy.UseVisualStyleBackColor = true;
            btnArbitraryCopy.Click += btnFirstCopy_Click;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(189, 31);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(725, 419);
            pnlContent.TabIndex = 2;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(lblCurentSection);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(189, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(725, 31);
            pnlHeader.TabIndex = 1;
            // 
            // lblCurentSection
            // 
            lblCurentSection.Anchor = AnchorStyles.None;
            lblCurentSection.AutoSize = true;
            lblCurentSection.Location = new Point(250, 9);
            lblCurentSection.Name = "lblCurentSection";
            lblCurentSection.Size = new Size(217, 15);
            lblCurentSection.TabIndex = 0;
            lblCurentSection.Text = "Копировальня готова к работе";
            // 
            // BackupProgramMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 450);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Controls.Add(pnlMenu);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            MaximizeBox = false;
            Name = "BackupProgramMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            pnlMenu.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Button btnArbitraryCopy;
        private Button btnCopyScheduler;
        private Button btnProgramSettings;
        private Button btnHelp;
        private Button btnCurrentTask;
        private Panel pnlContent;
        private Panel pnlHeader;
        private Label lblCurentSection;
    }
}
