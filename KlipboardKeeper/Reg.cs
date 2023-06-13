using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace KlipboardKeeper
{
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
}
