using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using WK.Libraries.SharpClipboardNS;
using System.Diagnostics;
using System.Linq;
using System.IO;
using System.Media;

namespace KlipboardKeeper
{
    public partial class IconApp : ApplicationContext
    {
        public static readonly string AppName = "KlipboardKeeper";

        private NotifyIcon notifyIcon;
        private ContextMenu notifyIconContextMenu;
        SharpClipboard clipboardManager;
        List<ClipboardItem> clipboardHistory = new List<ClipboardItem>();

        DateTime appStartTime = DateTime.Now;

        KlipboardKeeper.Forms.ClipboardHistoryWindow clipboardHistoryWindow;
        KlipboardKeeper.Forms.SettingsWindow settingsWindow = new KlipboardKeeper.Forms.SettingsWindow();

        public IconApp()
        {
            CheckForRunningInstance();

            InitializeSettings();

            // Initialize clipboard manager
            clipboardManager = new SharpClipboard();
            clipboardManager.ClipboardChanged += Clipboard_ClipboardChanged;

            // Initialize taskbar icon
            this.notifyIcon = new NotifyIcon();
            notifyIcon.Text = AppName;
            notifyIcon.Icon = Properties.Resources.clipboard;
            notifyIcon.Visible = true;

            InitContextMenu();

            notifyIcon.ContextMenu = notifyIconContextMenu; // Assign context menu to app icon
            notifyIcon.Click += NotifyIcon_Click; // Register icon click events

            if (settings.IsFirstStart)
            {
                settings.IsFirstStart = false;

                notifyIcon.BalloonTipTitle = "Your clipboard history lives here.";
                notifyIcon.BalloonTipText = "Click on the clipboard icon in the taskbar to access your clipboard history, or right-click on the icon for more options such as settings.";
                notifyIcon.BalloonTipClicked += NotifyIcon_BalloonTipClicked;
                notifyIcon.ShowBalloonTip(10000);
            }
        }

        private void NotifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            ShowSettingsWindow();
            notifyIcon.BalloonTipClicked -= NotifyIcon_BalloonTipClicked;
        }

        private void NotifyIcon_Click(object sender, EventArgs e)
        {
            ShowClipboardHistoryWindow();
        }

        void ShowClipboardHistoryWindow()
        {
            // Code to show clipboard history window
            clipboardHistoryWindow = new Forms.ClipboardHistoryWindow();
        }

        void ShowSettingsWindow()
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
            }
        }


        // Monitor clipboard events. It is rather imperative that we do this.
        private void Clipboard_ClipboardChanged(object sender, SharpClipboard.ClipboardChangedEventArgs e)
        {
            // I put a threshold here since SharpClipboard picks up the clipboard's current content as a change on startup. The solution is to essentially discard any clipboard data obtained within the first few seconds of the app starting.
            // Might consider making this a setting later
            TimeSpan threshold = TimeSpan.FromSeconds(3);

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
                    string sourceApplicationName = e.SourceApplication.Name;
                    string sourceApplicationTitle = e.SourceApplication.Title;
                    string content = clipboardManager.ClipboardText;
                    clipboardHistory.Add(new ClipboardItem(DateTime.Now, content));

                    if (settings.ShowCopyPreviewBalloon)
                    {
                        notifyIcon.BalloonTipTitle = string.Format("Text copied from {0}", sourceApplicationTitle);
                        notifyIcon.BalloonTipText = content;
                        notifyIcon.ShowBalloonTip(5000);
                    }
                }
            }
        }
    }
}
