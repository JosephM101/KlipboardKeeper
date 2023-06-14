using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.IO;
using System.Media;
using WK.Libraries.SharpClipboardNS;
using static KlipboardKeeper.IconApp;

namespace KlipboardKeeper
{
    public partial class IconApp : ApplicationContext
    {
        public static readonly string AppName = "KlipboardKeeper";

        private NotifyIcon notifyIcon;
        private ContextMenu notifyIconContextMenu;
        SharpClipboard clipboardManager;

        DateTime appStartTime = DateTime.Now;

        Forms.ClipboardHistoryWindow clipboardHistoryWindow = new Forms.ClipboardHistoryWindow();
        Forms.SettingsWindow settingsWindow = new Forms.SettingsWindow();

        public IconApp()
        {
            CheckForRunningInstance();

            InitializeSettings();

            // Initialize clipboard manager
            clipboardManager = new SharpClipboard();
            clipboardManager.ClipboardChanged += Clipboard_ClipboardChanged;

            source = new BindingSource(ClipboardHistory, null);

            // Initialize taskbar icon
            this.notifyIcon = new NotifyIcon();
            notifyIcon.MouseUp += NotifyIcon_MouseUp;
            notifyIcon.Text = AppName;
            notifyIcon.Icon = Properties.Resources.clipboard;
            notifyIcon.Visible = true;

            InitContextMenu();

            notifyIcon.ContextMenu = notifyIconContextMenu; // Assign context menu to app icon

            if (settings.IsFirstStart)
            {
                settings.IsFirstStart = false;

                notifyIcon.BalloonTipTitle = "Your clipboard history lives here.";
                notifyIcon.BalloonTipText = "Click on the clipboard icon in the taskbar to access your clipboard history, or right-click on the icon for more options such as settings.";
                notifyIcon.BalloonTipClicked += NotifyIcon_BalloonTipClicked;
                notifyIcon.ShowBalloonTip(10000);
            }

            if (settings.RememberClipboardHistory)
            {
                GetHistoryFromFile(); // Load saved history
            }

            clipboardHistoryWindow.VisibleChanged += ClipboardHistoryWindow_VisibleChanged;
            settingsWindow.VisibleChanged += SettingsWindow_VisibleChanged;
        }

        private void ClipboardHistoryWindow_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void SettingsWindow_VisibleChanged(object sender, EventArgs e)
        {
            showClipboardHistoryMenuItem.Enabled = !settingsWindow.Visible;
        }

        private void NotifyIcon_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ShowClipboardHistoryWindow();
            }
        }

        private void NotifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            ShowSettingsWindow();
            notifyIcon.BalloonTipClicked -= NotifyIcon_BalloonTipClicked;
        }

        void BringClipboardHistoryWindowToFront()
        {
            // clipboardHistoryWindow.WindowState = FormWindowState.Minimized;

            // clipboardHistoryWindow.Activate();
            clipboardHistoryWindow.Show();
            clipboardHistoryWindow.WindowState = FormWindowState.Normal;
            clipboardHistoryWindow.FlashNotification();
        }

        void ShowClipboardHistoryWindow()
        {
            if (showClipboardHistoryMenuItem.Enabled)
            {
                // Code to show clipboard history window
                if (clipboardHistoryWindow.Visible)
                {
                    BringClipboardHistoryWindowToFront();
                    SystemSounds.Asterisk.Play();
                }
                else
                {
                    /// TODO: Pass history to window
                    clipboardHistoryWindow.TopMost = settings.KeepHistoryWindowOnTop;
                    clipboardHistoryWindow.clipboardItems = this.ClipboardHistory;
                    clipboardHistoryWindow.ShowDialog(); // Show the dialog
                }
            }
        }

        void ShowSettingsWindow()
        {
            if (settingsMenuItem.Enabled)
            {
                if (settingsWindow.Visible)
                {
                    settingsWindow.BringToFront();
                    SystemSounds.Asterisk.Play();
                }
                else
                {
                    settingsWindow.settings = this.settings; // Give the Settings window a reference to our config
                    DialogResult result = settingsWindow.ShowDialog(); // Show the dialog
                    if (result == DialogResult.OK)
                    {
                        Debug.WriteLine("Settings saved");

                        TrimClipboardHistory(); // In case history limit was changed
                        if (!settings.RememberClipboardHistory)
                        {
                            DeleteHistoryFileIfExists();
                        }
                    }
                }
            }
            else
            {
                clipboardHistoryWindow.BringToFront();
            }
        }


        // Monitor clipboard events. It is rather imperative that we do this.
        private void Clipboard_ClipboardChanged(object sender, SharpClipboard.ClipboardChangedEventArgs e)
        {
            // I put a threshold here since SharpClipboard picks up the clipboard's current content as a change on startup. The solution is to essentially discard any clipboard data obtained within the first few seconds of the app starting.
            // Might consider making this a setting later
            TimeSpan threshold = TimeSpan.FromSeconds(5);

            DateTime clipboardChangeDetectedTime = DateTime.Now;
            TimeSpan difference = clipboardChangeDetectedTime - appStartTime;
            if (difference <= threshold && settings.IgnoreClipboardDataPresentAtStartup)
            {
                // Ignore content
                Debug.WriteLine("Ignoring current clipboard contents - within app startup time");
            }
            else
            {
                if (e.ContentType == SharpClipboard.ContentTypes.Text)
                {
                    // string sourceApplicationName = e.SourceApplication.Name;
                    string sourceApplicationTitle = e.SourceApplication.Title;
                    string content = clipboardManager.ClipboardText;
                    AppendToClipboardHistory(sourceApplicationTitle, content, DateTime.Now);

                    if (settings.ShowCopyPreviewBalloon)
                    {
                        notifyIcon.BalloonTipTitle = $"Text copied from \"{sourceApplicationTitle}\"";
                        notifyIcon.BalloonTipText = content;
                        notifyIcon.ShowBalloonTip(5000);
                    }
                }
            }
        }

        protected override void ExitThreadCore()
        {
            if (!settings.RememberClipboardHistory)
            {
                DeleteHistoryFileIfExists();
            }
            base.ExitThreadCore();
        }
    }
}
