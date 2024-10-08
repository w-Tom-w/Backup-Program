using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backup_Program.GUI
{
    public partial class SettingsGUI : UserControl
    {
        private static SettingsGUI _settingsGUI;
        public static SettingsGUI CreateSettingsGUI
        {
            get { return _settingsGUI ?? (_settingsGUI = new SettingsGUI()); }
        }

        public SettingsGUI()
        {
            InitializeComponent();
        }

        private void SettingsGUI_Load(object sender, EventArgs e)
        {

        }
    }
}
