using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KlipboardKeeper.IconApp;

namespace KlipboardKeeper.Forms
{
    public partial class ClipboardHistoryWindow : Form
    {
        public BindingList<ClipboardItem> clipboardItems;

        public ClipboardHistoryWindow()
        {
            InitializeComponent();
        }

        private void menuItem_closeWindow_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClipboardHistoryWindow_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = clipboardItems.ToArray();
        }
    }
}
