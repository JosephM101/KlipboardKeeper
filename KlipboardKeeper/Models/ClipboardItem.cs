using System;
using System.ComponentModel;

namespace KlipboardKeeper
{
    public partial class IconApp
    {
        [Serializable]
        public class ClipboardItem
        {
            [DisplayName("Contents")]
            public string Text { get; set; }

            [DisplayName("Source Application")]
            public string SourceApplication { get; internal set; }

            [DisplayName("Item Added")]
            public DateTime ItemAdded { get; internal set; }

        }
    }
}
