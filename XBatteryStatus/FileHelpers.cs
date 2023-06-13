using System;
using System.IO;

namespace XBatteryStatus
{
    internal class FileHelpers
    {
        public static string GetAppDataFolder()
        {
            try
            {
                // You'd think you could use Windows.Storage, but this just throws an exception (because not UWP?)
                // So this data won't be in the same location as settings
                string baseAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData, Environment.SpecialFolderOption.Create);
                string AppPath = Path.Combine(baseAppData, "XBatteryStatus");
                Directory.CreateDirectory(AppPath);
                return AppPath;
            }
            catch (Exception)
            {
                string TempPath = Path.Combine(Path.GetTempPath(), "XBatteryStatus");
                Directory.CreateDirectory(TempPath);
                return TempPath;
            }
        }
    }
}