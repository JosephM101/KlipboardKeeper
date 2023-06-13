using System;
using System.Windows.Forms;
using Config.Net;
using Microsoft.Win32;

namespace KlipboardKeeper.Forms
{
    public partial class SettingsWindow : Form
    {
        public IAppSettings settings;

        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            // Load settings
            numericUpDown_clipboardHistory_maxSize.Value = settings.MaxHistoryLength;
            checkBox_uiOptions_keepHistoryWindowOnTop.Checked = settings.KeepHistoryWindowOnTop;
            checkBox_uiOptions_showCopyPreviewBalloon.Checked = settings.ShowCopyPreviewBalloon;
            checkBox_behavior_ignoreClipboardDataPresentAtStartup.Checked = settings.IgnoreClipboardDataPresentAtStartup;
            checkBox_memory_rememberClipboardHistory.Checked = settings.RememberClipboardHistory;

            checkBox_startup_startWithWindows.Checked = Reg.RegistryValueExists("Software\\Microsoft\\Windows\\CurrentVersion\\Run", "KlipboardKeeper", RegistryHive.CurrentUser);
        }

        private void numericUpDown_clipboardHistory_maxSize_ValueChanged(object sender, EventArgs e)
        {
            settings.MaxHistoryLength = (int)numericUpDown_clipboardHistory_maxSize.Value;
        }

        private void checkBox_uiOptions_keepHistoryWindowOnTop_CheckedChanged(object sender, EventArgs e)
        {
            settings.KeepHistoryWindowOnTop = checkBox_uiOptions_keepHistoryWindowOnTop.Checked;
        }

        private void checkBox_uiOptions_showCopyPreviewBalloon_CheckedChanged(object sender, EventArgs e)
        {
            settings.ShowCopyPreviewBalloon = checkBox_uiOptions_showCopyPreviewBalloon.Checked;
        }

        private void checkBox_behavior_ignoreClipboardDataPresentAtStartup_CheckedChanged(object sender, EventArgs e)
        {
            settings.IgnoreClipboardDataPresentAtStartup = checkBox_behavior_ignoreClipboardDataPresentAtStartup.Checked;
        }

        private void checkBox_memory_rememberClipboardHistory_CheckedChanged(object sender, EventArgs e)
        {
            settings.RememberClipboardHistory = checkBox_memory_rememberClipboardHistory.Checked;
        }

        private void checkBox_startup_startWithWindows_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_startup_startWithWindows.Checked)
            {
                string exeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "KlipboardKeeper", exeFilePath, RegistryValueKind.String);
            }
            else
            {
                if (Reg.RegistryValueExists("Software\\Microsoft\\Windows\\CurrentVersion\\Run", "KlipboardKeeper", RegistryHive.CurrentUser))
                {
                    Reg.DeleteValue("Software\\Microsoft\\Windows\\CurrentVersion\\Run", "KlipboardKeeper", RegistryHive.CurrentUser);
                }
            }
        }
    }
}
