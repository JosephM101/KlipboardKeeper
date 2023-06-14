using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlipboardKeeper.Forms
{
    public partial class ClipboardHistoryWindow : Form
    {
        public ClipboardHistoryWindow()
        {
            InitializeComponent();
        }

        private void ClipboardHistory_Load(object sender, EventArgs e)
        {

        }

        private void menuItem_closeWindow_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
