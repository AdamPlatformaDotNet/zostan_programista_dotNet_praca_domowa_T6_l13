using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ImagePicker.Properties
{
    [CompilerGenerated]
    [SettingsProvider(typeof(LocalFileSettingsProvider))]
    internal sealed partial class Settings : ApplicationSettingsBase
    {
        private static readonly Settings instance =
            (Settings)Synchronized(new Settings());

        public static Settings Default => instance;

        [UserScopedSetting]
        [DefaultSettingValue("")]
        [DebuggerNonUserCode]
        public string SelectedPath
        {
            get => (string)this[nameof(SelectedPath)];
            set => this[nameof(SelectedPath)] = value;
        }
        
    }
}