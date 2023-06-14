using System;

namespace KlipboardKeeper
{
    public partial class IconApp
    {
        [Serializable]
        public class ClipboardItem
        {
            public DateTime ItemAdded { get; set; }
            public string SourceApplication { get; set; }
            public string Text { get; set; }
        }
    }
}
