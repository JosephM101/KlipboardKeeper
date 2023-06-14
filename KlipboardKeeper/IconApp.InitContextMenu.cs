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
        MenuItem showClipboardHistoryMenuItem;
        MenuItem settingsMenuItem;
        MenuItem exitMenuItem;

        public void InitContextMenu()
        {
            // Initialize context menu for taskbar icon & add items
            this.notifyIconContextMenu = new ContextMenu();

            showClipboardHistoryMenuItem = new MenuItem("Show clipboard history", (o, e) =>
            {
                // Show clipboard history window
                ShowClipboardHistoryWindow();
            });
            settingsMenuItem = new MenuItem("Settings", (o, e) =>
            {
                ShowSettingsWindow();
            });
            exitMenuItem = new MenuItem("Exit", (o, e) =>
            {
                string end = settings.RememberClipboardHistory ? "Your current clipboard history will remain intact." : "All clipboard history will be lost!";
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to close {AppName}? \n{end}",
                    AppName,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            });

            notifyIconContextMenu.MenuItems.Add(showClipboardHistoryMenuItem);
            notifyIconContextMenu.MenuItems.Add(settingsMenuItem);
            notifyIconContextMenu.MenuItems.Add(exitMenuItem);
        }
    }
}
