using Config.Net;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;
using static KlipboardKeeper.IconApp;

namespace KlipboardKeeper
{
    public interface IAppSettings
    {
        [Option(Alias = "maxHistoryLength", DefaultValue = 10)]
        int MaxHistoryLength { get; set; }

        [Option(Alias = "firstStart", DefaultValue = true)]
        bool IsFirstStart { get; set; }

        [Option(Alias = "ui.keepOnTop", DefaultValue = true)]
        bool KeepHistoryWindowOnTop { get; set; }

        [Option(Alias = "ui.showCopyPreviewBalloon", DefaultValue = true)]
        bool ShowCopyPreviewBalloon { get; set; }

        [Option(Alias = "behavior.ignoreClipboardDataPresentAtStartup", DefaultValue = true)]
        bool IgnoreClipboardDataPresentAtStartup { get; set; }

        [Option(Alias = "memory.rememberClipboardHistory", DefaultValue = false)]
        bool RememberClipboardHistory { get; set; }
    }

    public partial class IconApp : ApplicationContext
    {
        IAppSettings settings;
        public static readonly string SettingsFileName = "KlipboardKeeper.json";

        // Initialize settings
        public void InitializeSettings()
        {
            settings = new ConfigurationBuilder<IAppSettings>()
                .UseJsonFile(SettingsFileName)
                .Build();
        }
    }
}