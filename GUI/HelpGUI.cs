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
    public partial class HelpGUI : UserControl
    {
        private static HelpGUI _helpGUI;
        public static HelpGUI CreateHelpGUI
        {
            get { return _helpGUI ?? (_helpGUI = new HelpGUI()); }
        }

        public HelpGUI()
        {
            InitializeComponent();
        }

        private void HelpGUI_Load(object sender, EventArgs e)
        {

        }
    }
}
