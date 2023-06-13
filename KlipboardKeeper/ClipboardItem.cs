using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlipboardKeeper
{
    public class ClipboardItem
    {
        public DateTime ItemAdded { get; internal set; }
        public string ClipboardTextContents { get; internal set; }

        public ClipboardItem(DateTime itemAdded, string clipboardTextContents)
        {
            ItemAdded = itemAdded;
            ClipboardTextContents = clipboardTextContents;
        }
    }
}
