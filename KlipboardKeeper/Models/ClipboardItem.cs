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
            public string SourceApplication { get; set; }

            [DisplayName("Capture time")]
            public DateTime CaptureTime { get; set; }

            [Browsable(false)]
            public System.Guid Guid { get; set; }

            public ClipboardItem()
            {
                Guid = Guid.NewGuid();
            }
        }
    }
}
