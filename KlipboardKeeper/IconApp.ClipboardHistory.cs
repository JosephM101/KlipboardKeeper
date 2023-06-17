using KlipboardKeeper.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace KlipboardKeeper
{
    public partial class IconApp : ApplicationContext
    {
        private readonly string PersistentHistoryFileName = ConfigFileHelper.GetConfigPath(Common.ClipboardHistoryFilename);
        private readonly object clipboardHistoryListLock = new object();
        public BindingList<ClipboardItem> ClipboardHistory = new BindingList<ClipboardItem>();
        public BindingSource source;

        // Code to handle clipboard history
        void AppendToClipboardHistory(string sourceApplication, string clipboardText, DateTime captureTime)
        {
            ClipboardHistory_PrepareUpdate(); // Disable history window's ability to update
            lock (clipboardHistoryListLock) // We lock the list object because the Clipboard History UI thread and this thread will fight over accessing it, causing a race condition, and therefore crashing the program.
            {
                // Check if the copy is a potential duplicate, and don't add it if the setting for avoiding duplicates is enabled
                bool isPotentialDuplicate = ClipboardHistory.Any(item => item.Text.Equals(clipboardText));
                if (!(isPotentialDuplicate && settings.PreventDuplicateItems))
                {
                    ClipboardHistory.Add(new ClipboardItem()
                    {
                        Text = clipboardText,
                        SourceApplication = sourceApplication,
                        CaptureTime = captureTime
                    });
                }
            }

            TrimClipboardHistory(); // Cleanup, and keep in bounds

            if (settings.RememberClipboardHistory)
            {
                SaveHistoryToFile();
            }
            ClipboardHistory_FinishUpdate(); // Allow history window to update
        }

        // Make sure the number of items stored in the clipboard history are within the set boundaries
        void TrimClipboardHistory()
        {
            lock (clipboardHistoryListLock)
            {
                while (ClipboardHistory.Count > settings.MaxHistoryLength)
                {
                    // Delete the oldest entry
                    ClipboardItem oldest = ClipboardHistory.OrderBy(x => x.CaptureTime).First();
                    ClipboardHistory.Remove(oldest);
                }

                foreach (ClipboardItem empty in ClipboardHistory.Where(item => string.IsNullOrWhiteSpace(item.Text)).ToList())
                {
                    ClipboardHistory.Remove(empty);
                }
            }
        }

        void SaveHistoryToFile()
        {
            lock (clipboardHistoryListLock)
            {
                // Serialize history to file
                DeleteHistoryFileIfExists();
                XmlSerializer xmlSerializer = new XmlSerializer(ClipboardHistory.GetType());
                using (StreamWriter streamWriter = new StreamWriter(PersistentHistoryFileName))
                {
                    xmlSerializer.Serialize(streamWriter, ClipboardHistory);
                }
            }
        }

        void GetHistoryFromFile()
        {
            lock (clipboardHistoryListLock)
            {
                if (File.Exists(PersistentHistoryFileName))
                {
                    ClipboardHistory.Clear();

                    List<ClipboardItem> temp = new List<ClipboardItem>();
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<ClipboardItem>));
                    using (StreamReader streamReader = new StreamReader(PersistentHistoryFileName))
                    {
                        temp = (List<ClipboardItem>)xmlSerializer.Deserialize(streamReader);
                    }

                    foreach (ClipboardItem item in temp)
                    {
                        ClipboardHistory.Add(item); // Add items back into local list
                    }
                }
            }
        }

        void DeleteHistoryFileIfExists()
        {
            if (File.Exists(PersistentHistoryFileName))
            {
                try
                {
                    File.Delete(PersistentHistoryFileName);
                }
                catch
                {

                }
            }
        }

        void ClipboardHistory_PrepareUpdate()
        {
            clipboardHistoryWindow.dataGridView.DataSource = null;
        }

        void ClipboardHistory_FinishUpdate()
        {
            // clipboardHistoryWindow.dataGridView.DataSource = this.ClipboardHistory;
            clipboardHistoryWindow.dataGridView.DataSource = clipboardHistoryWindow.clipboardHistory;
        }
    }
}