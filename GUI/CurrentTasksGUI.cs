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
    public partial class CurrentTasksGUI : UserControl
    {
        private static CurrentTasksGUI _currentTasksGUI;
        public static CurrentTasksGUI CreateCurrentTasksGUI
        {
            get { return _currentTasksGUI ?? (_currentTasksGUI = new CurrentTasksGUI()); }
        }


        public CurrentTasksGUI()
        {
            InitializeComponent();
        }

        private void CurrentTasksGUI_Load(object sender, EventArgs e)
        {

        }
    }
}
