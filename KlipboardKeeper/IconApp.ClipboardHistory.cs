using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace KlipboardKeeper
{
    public partial class IconApp : ApplicationContext
    {
        private string PersistentHistoryFileName = "KlipboardKeeper.history";
        public List<ClipboardItem> ClipboardHistory = new List<ClipboardItem>();


        // Code to handle clipboard history
        void AppendToClipboardHistory(string sourceAppName, string clipboardText, DateTime captureTime)
        {
            ClipboardHistory.Add(new ClipboardItem()
            {
                ItemAdded = DateTime.Now,
                SourceApplication = sourceAppName,
                Text = clipboardText
            });

            TrimClipboardHistory();

            if (settings.RememberClipboardHistory)
            {
                SaveHistoryToFile();
            }
        }

        // Make sure the number of items stored in the clipboard history are within the set boundaries
        void TrimClipboardHistory()
        {
            while (ClipboardHistory.Count > settings.MaxHistoryLength)
            {
                // Delete the oldest entry
                ClipboardItem oldest = ClipboardHistory.OrderBy(x => x.ItemAdded).First();
                ClipboardHistory.Remove(oldest);
            }
        }

        void SaveHistoryToFile()
        {
            // Serialize history to file
            DeleteHistoryFileIfExists();
            XmlSerializer xmlSerializer = new XmlSerializer(ClipboardHistory.GetType());
            using (StreamWriter streamWriter = new StreamWriter(PersistentHistoryFileName))
            {
                xmlSerializer.Serialize(streamWriter, ClipboardHistory);
            }
        }

        void GetHistoryFromFile()
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
    }
}