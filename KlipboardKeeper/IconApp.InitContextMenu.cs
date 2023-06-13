using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlipboardKeeper
{
    public partial class IconApp : ApplicationContext
    {
        public void InitContextMenu()
        {
            // Initialize context menu for taskbar icon & add items
            this.notifyIconContextMenu = new ContextMenu();
            notifyIconContextMenu.MenuItems.Add("Show clipboard history", (o, e) =>
            {
                // Show clipboard history window
                ShowClipboardHistoryWindow();
            });

            notifyIconContextMenu.MenuItems.Add("Settings", (o, e) =>
            {
                ShowSettingsWindow();
            });
            notifyIconContextMenu.MenuItems.Add("Exit", (o, e) =>
            {
                DialogResult result = MessageBox.Show(
                    string.Format("Are you sure you want to close {0}? All clipboard history will be lost.", AppName),
                    AppName,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            });
        }
    }
}
