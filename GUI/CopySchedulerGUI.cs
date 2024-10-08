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
    public partial class CopySchedulerGUI : UserControl
    {
        private static CopySchedulerGUI _copySchedulerGUI;
        public static CopySchedulerGUI CreateCopySchedulerGUI
        {
            get { return _copySchedulerGUI ?? (_copySchedulerGUI = new CopySchedulerGUI()); }
        }

        public CopySchedulerGUI()
        {
            InitializeComponent();
        }

        private void CopySchedulerGUI_Load(object sender, EventArgs e)
        {

        }
    }
}
