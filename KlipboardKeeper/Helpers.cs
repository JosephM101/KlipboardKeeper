using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KlipboardKeeper.Helpers
{
    public static class ConfigFileHelper
    {
        private static string DebugPrefix = "CONFIG: ";
        /*
        public static string GetConfigPath(string filename)
        {
            // Check if the application is running as a portable version
            if (IsPortableVersion())
            {
                // If the application is running as a portable version, check if it has write access to the current directory
                if (HasWriteAccessToFolder(Directory.GetCurrentDirectory()))
                {
                    Debug.WriteLine($"{DebugPrefix}Using local directory (portable mode)");
                    return Path.Combine(Directory.GetCurrentDirectory(), filename);
                }
                else
                {
                    // If the application does not have write access to the current directory, create a log file on the user's desktop
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string logFilePath = Path.Combine(desktopPath, "KlipboardKeeper-log.txt");
                    File.WriteAllText(logFilePath, "Error: KlipboardKeeper portable version cannot write to the current directory.");

                    // Terminate the application
                    Environment.Exit(1);
                    return null;
                }
            }
            else
            {
                if (HasWriteAccessToFolder(Directory.GetCurrentDirectory()))
                {
                    Debug.WriteLine($"{DebugPrefix}Using local directory");
                    return Path.Combine(Directory.GetCurrentDirectory(), filename);
                }
                else
                {
                    // If the application is not running as a portable version, use the user's AppData folder
                    string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                    string appFolder = Path.Combine(appDataPath, "KlipboardKeeper");
                    Directory.CreateDirectory(appFolder);
                    Debug.WriteLine($"{DebugPrefix}Using config directory \"{appFolder}\"");
                    return Path.Combine(appFolder, filename);
                }
            }
        }
        */

        public static string GetConfigPath(string filename)
        {
            // Check if the application is running as a portable version
            if (IsPortableVersion())
            {
                // If the application is running as a portable version, check if it has write access to the current directory
                if (HasWriteAccessToFolder(Directory.GetCurrentDirectory()))
                {
                    Debug.WriteLine($"{DebugPrefix}Using local directory (portable mode)");
                    return Path.Combine(Directory.GetCurrentDirectory(), filename);
                }
                else
                {
                    // If the application does not have write access to the current directory, create a log file on the user's desktop
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string logFilePath = Path.Combine(desktopPath, "KlipboardKeeper-log.txt");
                    File.WriteAllText(logFilePath, "Error: KlipboardKeeper portable version cannot write to the current directory.");

                    // Terminate the application
                    Environment.Exit(1);
                    return null;
                }
            }
            else
            {
                if (IsRunningFromProgramFiles())
                {
                    Debug.WriteLine("Detected installation, using AppData folder for configuration");
                    // If the application is not running as a portable version, use the user's AppData folder
                    string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                    string appFolder = Path.Combine(appDataPath, "KlipboardKeeper");
                    Directory.CreateDirectory(appFolder);
                    Debug.WriteLine($"{DebugPrefix}Using config directory \"{appFolder}\"");
                    return Path.Combine(appFolder, filename);
                }
            }
        }

        public static bool HasWriteAccessToFolder(string folderPath)
        {
            try
            {
                // Attempt to get a list of security permissions from the folder.
                // This will raise an exception if the path is read only or do not have access to view the permissions.
                System.Security.AccessControl.DirectorySecurity ds = Directory.GetAccessControl(folderPath);
                return true;
            }
            catch (UnauthorizedAccessException)
            {
                return false;
            }
        }

        private static bool IsPortableVersion()
        {
            string exeName = Assembly.GetExecutingAssembly().Location;
            return exeName.EndsWith("KlipboardKeeper-portable.exe");
        }

        public static bool IsRunningFromProgramFiles()
        {
            string programFilesPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            string programFilesX86Path = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);

            string currentDirectory = Directory.GetCurrentDirectory();

            return currentDirectory.StartsWith(programFilesPath) || currentDirectory.StartsWith(programFilesX86Path);
        }
    }

    public static class Reg
    {
        public static bool RegistryValueExists(string keyPath, string valueName, RegistryHive hive = RegistryHive.LocalMachine)
        {
            using (RegistryKey baseKey = RegistryKey.OpenBaseKey(hive, RegistryView.Default))
            {
                using (RegistryKey key = baseKey.OpenSubKey(keyPath))
                {
                    if (key != null)
                    {
                        object value = key.GetValue(valueName);
                        return value != null;
                    }
                }
            }

            return false;
        }

        public static void DeleteValue(string keyPath, string valueName, RegistryHive hive = RegistryHive.LocalMachine)
        {
            using (RegistryKey baseKey = RegistryKey.OpenBaseKey(hive, RegistryView.Default))
            {
                using (RegistryKey key = baseKey.OpenSubKey(keyPath, true))
                {
                    key.DeleteValue(valueName, false);
                }
            }
        }
    }

    public static class FlashWindow
    {
        // To support flashing.
        [DllImport("user32.dll")]
        private static extern int FlashWindowEx(ref FLASHWINFO pwfi);

        //Flash both the window caption and taskbar button.
        //This is equivalent to setting the FLASHW_CAPTION | FLASHW_TRAY flags. 
        private const uint FLASHW_ALL = 3;

        // Flash continuously until the window comes to the foreground. 
        private const uint FLASHW_TIMERNOFG = 12;

        [StructLayout(LayoutKind.Sequential)]
        private struct FLASHWINFO
        {
            public uint cbSize;
            public IntPtr hwnd;
            public uint dwFlags;
            public uint uCount;
            public uint dwTimeout;
        }

        /// <summary>
        /// Send form taskbar notification, the Window will flash until get's focus
        /// <remarks>
        /// This method allows to Flash a Window, signifying to the user that some major event occurred within the application that requires their attention. 
        /// </remarks>
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        public static void FlashNotification(this Form form)
        {
            IntPtr hWnd = form.Handle;
            FLASHWINFO fInfo = new FLASHWINFO();

            fInfo.cbSize = Convert.ToUInt32(Marshal.SizeOf(fInfo));
            fInfo.hwnd = hWnd;
            fInfo.dwFlags = FLASHW_ALL | FLASHW_TIMERNOFG;
            fInfo.uCount = 10;
            fInfo.dwTimeout = 150;

            FlashWindowEx(ref fInfo);
        }
    }
}