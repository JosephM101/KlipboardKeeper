using System.Diagnostics;
using System.IO;
using System.Linq;
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
                    $"{AppName} is already running! \n" +
                    $"\n" +
                    $"To access your clipboard history, click on the 'clipboard' icon in the taskbar. If you don't see the icon, it may be hiding in your taskbar's overflow menu.",
                    AppName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                Process.GetCurrentProcess().Kill(); // Die; we don't want multiple instances running.
            }
        }
    }
}
