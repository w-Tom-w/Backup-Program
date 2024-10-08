using Backup_Program.GUI;

namespace Backup_Program
{
    public partial class BackupProgramMainForm : Form
    {
        
        public BackupProgramMainForm()
        {
            InitializeComponent();
        }

        private void btnFirstCopy_Click(object sender, EventArgs e)
        {
            lblCurentSection.Text = "Быстрое копирование";
            if (!pnlContent.Controls.Contains(FirstCopyGUI.CreateFirstCopyGUI))
            {
                pnlContent.Controls.Add(FirstCopyGUI.CreateFirstCopyGUI);
                FirstCopyGUI.CreateFirstCopyGUI.Dock = DockStyle.Fill;
                FirstCopyGUI.CreateFirstCopyGUI.BringToFront();
            }
            else
            {
                FirstCopyGUI.CreateFirstCopyGUI.BringToFront();
            }
        }

        private void btnCopyScheduler_Click(object sender, EventArgs e)
        {
            lblCurentSection.Text = "Запланировать копирование";
            if (!pnlContent.Controls.Contains(CopySchedulerGUI.CreateCopySchedulerGUI))
            {
                pnlContent.Controls.Add(CopySchedulerGUI.CreateCopySchedulerGUI);
                CopySchedulerGUI.CreateCopySchedulerGUI.Dock = DockStyle.Fill;
                CopySchedulerGUI.CreateCopySchedulerGUI.BringToFront();
            }
            else
            {
                CopySchedulerGUI.CreateCopySchedulerGUI.BringToFront();
            }
        }

        private void btnCurrentTask_Click(object sender, EventArgs e)
        {
            lblCurentSection.Text = "Текущие задачи";
            if (!pnlContent.Controls.Contains(CurrentTasksGUI.CreateCurrentTasksGUI))
            {
                pnlContent.Controls.Add(CurrentTasksGUI.CreateCurrentTasksGUI);
                CurrentTasksGUI.CreateCurrentTasksGUI.Dock = DockStyle.Fill;
                CurrentTasksGUI.CreateCurrentTasksGUI.BringToFront();
            }
            else
            {
                CurrentTasksGUI.CreateCurrentTasksGUI.BringToFront();
            }
        }

        private void btnProgramSettings_Click(object sender, EventArgs e)
        {
            lblCurentSection.Text = "Настройки";
            if (!pnlContent.Controls.Contains(SettingsGUI.CreateSettingsGUI))
            {
                pnlContent.Controls.Add(SettingsGUI.CreateSettingsGUI);
                SettingsGUI.CreateSettingsGUI.Dock = DockStyle.Fill;
                SettingsGUI.CreateSettingsGUI.BringToFront();
            }
            else
            {
                SettingsGUI.CreateSettingsGUI.BringToFront();
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            lblCurentSection.Text = "Справка";
            if (!pnlContent.Controls.Contains(HelpGUI.CreateHelpGUI))
            {
                pnlContent.Controls.Add(HelpGUI.CreateHelpGUI);
                HelpGUI.CreateHelpGUI.Dock = DockStyle.Fill;
                HelpGUI.CreateHelpGUI.BringToFront();
            }
            else
            {
                HelpGUI.CreateHelpGUI.BringToFront();
            }
        }
    }
}
