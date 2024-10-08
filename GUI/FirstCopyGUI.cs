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
    public partial class FirstCopyGUI : UserControl
    {

        private static FirstCopyGUI _firstCopyGUI;
        public static FirstCopyGUI CreateFirstCopyGUI
        {
            get { return _firstCopyGUI ?? (_firstCopyGUI = new FirstCopyGUI()); }
        }

        public FirstCopyGUI()
        {
            InitializeComponent();
        }

        private void ArbitraryCopyGUI_Load(object sender, EventArgs e)
        {

        }
    }
}
