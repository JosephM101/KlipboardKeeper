using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlipboardKeeper
{
    public partial class IconApp : ApplicationContext
    {
        public void CheckForRunningInstance()
        {
            // Check if KlipboardKeeper is already running, and throw an error/terminate if it is
            if (Process.GetProcessesByName(Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Count() > 1)
            {
                MessageBox.Show(
                    $"{AppName} is already running! \n\nTo access captured items from your clipboard, click on the 'clipboard' icon in the taskbar.",
                    AppName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                Process.GetCurrentProcess().Kill(); // Die; we don't want multiple instances running.
            }
        }
    }
}
