using System;
using System.IO;
using System.Windows.Forms;
using KlipboardKeeper.Helpers;
using Microsoft.Win32;

namespace KlipboardKeeper.Forms
{
    public partial class SettingsWindow : Form
    {
        public IAppSettings settings;
        public string close_reason = "";

        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
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
            checkBox_behavior_tryToPreventDuplicates.Checked = settings.PreventDuplicateItems;
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
        private void checkBox_behavior_tryToPreventDuplicates_CheckedChanged(object sender, EventArgs e)
        {
            settings.PreventDuplicateItems = checkBox_behavior_tryToPreventDuplicates.Checked;
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

        private void button_resetDialogFlags_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Any one-time dialogs previously shown will appear again. This includes first-start messages.\n\nContinue?",
                                                  "Reset dialog flags",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                settings.EntryEditor_FirstStartMessageShown = false;
                MessageBox.Show("Dialog flags reset.", "KlipboardKeeper Settings");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to reset EVERYTHING?\n" +
                                                  "This clears your settings as well as any saved data. This cannot be undone.\n" +
                                                  "Once everything is reset, KlipboardKeeper will close.\n" +
                                                  "\n" +
                                                  "Continue?",
                                                  "Reset everything?",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                close_reason = "RESET_ALL";
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}