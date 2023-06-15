using System;
using System.Windows.Forms;

namespace KlipboardKeeper.Forms
{
    public partial class KlipboardKeeper_Editor_WelcomeMessage : Form
    {
        public KlipboardKeeper_Editor_WelcomeMessage()
        {
            InitializeComponent();
        }

        public KlipboardKeeper_Editor_WelcomeMessage(bool topMost)
        {
            InitializeComponent();
            this.TopMost = topMost;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
