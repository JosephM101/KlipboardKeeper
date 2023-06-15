using Config.Net;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;
using static KlipboardKeeper.IconApp;
using KlipboardKeeper.Helpers;

namespace KlipboardKeeper
{
    public interface IAppSettings
    {
        [Option(Alias = "maxHistoryLength", DefaultValue = 10)]
        int MaxHistoryLength { get; set; }

        [Option(Alias = "flags.firstStart", DefaultValue = true)]
        bool IsFirstStart { get; set; }

        [Option(Alias = "flags.entryEditorFirstStartMessageShown", DefaultValue = false)]
        bool EntryEditor_FirstStartMessageShown { get; set; }

        [Option(Alias = "ui.keepOnTop", DefaultValue = true)]
        bool KeepHistoryWindowOnTop { get; set; }

        [Option(Alias = "ui.showCopyPreviewBalloon", DefaultValue = true)]
        bool ShowCopyPreviewBalloon { get; set; }

        [Option(Alias = "behavior.ignoreClipboardDataPresentAtStartup", DefaultValue = true)]
        bool IgnoreClipboardDataPresentAtStartup { get; set; }

        [Option(Alias = "behavior.preventDuplicateItems", DefaultValue = true)]
        bool PreventDuplicateItems { get; set; }

        [Option(Alias = "memory.rememberClipboardHistory", DefaultValue = false)]
        bool RememberClipboardHistory { get; set; }

        /// TODO: Add setting to allow specifying applications/windows to ignore clipboard events from
    }

    public partial class IconApp : ApplicationContext
    {
        IAppSettings settings;
        public static readonly string SettingsFileName = ConfigFileHelper.GetConfigPath("KlipboardKeeper.json");

        // Initialize settings
        public void InitializeSettings()
        {
            settings = new ConfigurationBuilder<IAppSettings>()
                .UseJsonFile(SettingsFileName)
                .Build();
        }
    }
}