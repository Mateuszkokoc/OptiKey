﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JuliusSweetland.ETTA.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("LControlKey")]
        public global::System.Windows.Forms.Keys SelectionTriggerKeyboardKeyDownUpKey {
            get {
                return ((global::System.Windows.Forms.Keys)(this["SelectionTriggerKeyboardKeyDownUpKey"]));
            }
            set {
                this["SelectionTriggerKeyboardKeyDownUpKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("NextHigh")]
        public global::JuliusSweetland.ETTA.Enums.TriggerStopSignals SelectionTriggerStopSignal {
            get {
                return ((global::JuliusSweetland.ETTA.Enums.TriggerStopSignals)(this["SelectionTriggerStopSignal"]));
            }
            set {
                this["SelectionTriggerStopSignal"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Left")]
        public global::System.Windows.Forms.MouseButtons SelectionTriggerMouseDownUpButton {
            get {
                return ((global::System.Windows.Forms.MouseButtons)(this["SelectionTriggerMouseDownUpButton"]));
            }
            set {
                this["SelectionTriggerMouseDownUpButton"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Fixations")]
        public global::JuliusSweetland.ETTA.Enums.TriggerSources KeySelectionTriggerSource {
            get {
                return ((global::JuliusSweetland.ETTA.Enums.TriggerSources)(this["KeySelectionTriggerSource"]));
            }
            set {
                this["KeySelectionTriggerSource"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SettingsUpgradeRequired {
            get {
                return ((bool)(this["SettingsUpgradeRequired"]));
            }
            set {
                this["SettingsUpgradeRequired"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:00:00.0130000")]
        public global::System.TimeSpan PointsMousePositionSampleInterval {
            get {
                return ((global::System.TimeSpan)(this["PointsMousePositionSampleInterval"]));
            }
            set {
                this["PointsMousePositionSampleInterval"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("MousePosition")]
        public global::JuliusSweetland.ETTA.Enums.PointsSources PointsSource {
            get {
                return ((global::JuliusSweetland.ETTA.Enums.PointsSources)(this["PointsSource"]));
            }
            set {
                this["PointsSource"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:00:00.1500000")]
        public global::System.TimeSpan PointTtl {
            get {
                return ((global::System.TimeSpan)(this["PointTtl"]));
            }
            set {
                this["PointTtl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("50")]
        public double PointSelectionTriggerFixationRadius {
            get {
                return ((double)(this["PointSelectionTriggerFixationRadius"]));
            }
            set {
                this["PointSelectionTriggerFixationRadius"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("15")]
        public int PointSelectionTriggerFixationMinPoints {
            get {
                return ((int)(this["PointSelectionTriggerFixationMinPoints"]));
            }
            set {
                this["PointSelectionTriggerFixationMinPoints"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:00:01")]
        public global::System.TimeSpan PointSelectionTriggerFixationTime {
            get {
                return ((global::System.TimeSpan)(this["PointSelectionTriggerFixationTime"]));
            }
            set {
                this["PointSelectionTriggerFixationTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("6666")]
        public int GazeTrackerUdpPort {
            get {
                return ((int)(this["GazeTrackerUdpPort"]));
            }
            set {
                this["GazeTrackerUdpPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("^STREAM_DATA\\s(?<instanceTime>\\d+)\\s(?<x>-?\\d+(\\.[0-9]+)?)\\s(?<y>-?\\d+(\\.[0-9]+)?" +
            ")")]
        public string GazeTrackerUdpRegex {
            get {
                return ((string)(this["GazeTrackerUdpRegex"]));
            }
            set {
                this["GazeTrackerUdpRegex"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool MultiKeySelectionSupported {
            get {
                return ((bool)(this["MultiKeySelectionSupported"]));
            }
            set {
                this["MultiKeySelectionSupported"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:00:00.0500000")]
        public global::System.TimeSpan MultiKeySelectionFixationMinDwellTime {
            get {
                return ((global::System.TimeSpan)(this["MultiKeySelectionFixationMinDwellTime"]));
            }
            set {
                this["MultiKeySelectionFixationMinDwellTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("40")]
        public int MultiKeySelectionMaxDictionaryMatches {
            get {
                return ((int)(this["MultiKeySelectionMaxDictionaryMatches"]));
            }
            set {
                this["MultiKeySelectionMaxDictionaryMatches"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:01:00")]
        public global::System.TimeSpan MultiKeySelectionMaxDuration {
            get {
                return ((global::System.TimeSpan)(this["MultiKeySelectionMaxDuration"]));
            }
            set {
                this["MultiKeySelectionMaxDuration"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("BritishEnglish")]
        public global::JuliusSweetland.ETTA.Enums.Languages Language {
            get {
                return ((global::JuliusSweetland.ETTA.Enums.Languages)(this["Language"]));
            }
            set {
                this["Language"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Fixations")]
        public global::JuliusSweetland.ETTA.Enums.TriggerSources PointSelectionTriggerSource {
            get {
                return ((global::JuliusSweetland.ETTA.Enums.TriggerSources)(this["PointSelectionTriggerSource"]));
            }
            set {
                this["PointSelectionTriggerSource"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("15")]
        public int KeySelectionTriggerFixationMinPoints {
            get {
                return ((int)(this["KeySelectionTriggerFixationMinPoints"]));
            }
            set {
                this["KeySelectionTriggerFixationMinPoints"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:00:01")]
        public global::System.TimeSpan KeySelectionTriggerFixationTime {
            get {
                return ((global::System.TimeSpan)(this["KeySelectionTriggerFixationTime"]));
            }
            set {
                this["KeySelectionTriggerFixationTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("800")]
        public double MainWindowHeight {
            get {
                return ((double)(this["MainWindowHeight"]));
            }
            set {
                this["MainWindowHeight"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public double MainWindowLeft {
            get {
                return ((double)(this["MainWindowLeft"]));
            }
            set {
                this["MainWindowLeft"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Normal")]
        public global::System.Windows.WindowState MainWindowState {
            get {
                return ((global::System.Windows.WindowState)(this["MainWindowState"]));
            }
            set {
                this["MainWindowState"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public double MainWindowTop {
            get {
                return ((double)(this["MainWindowTop"]));
            }
            set {
                this["MainWindowTop"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1200")]
        public double MainWindowWidth {
            get {
                return ((double)(this["MainWindowWidth"]));
            }
            set {
                this["MainWindowWidth"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("25")]
        public int ToastNotificationTitleFontSize {
            get {
                return ((int)(this["ToastNotificationTitleFontSize"]));
            }
            set {
                this["ToastNotificationTitleFontSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("16")]
        public int ToastNotificationContentFontSize {
            get {
                return ((int)(this["ToastNotificationContentFontSize"]));
            }
            set {
                this["ToastNotificationContentFontSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("50")]
        public int ToastNotificationCharactersPerLine {
            get {
                return ((int)(this["ToastNotificationCharactersPerLine"]));
            }
            set {
                this["ToastNotificationCharactersPerLine"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int ToastNotificationSecondsPerLine {
            get {
                return ((int)(this["ToastNotificationSecondsPerLine"]));
            }
            set {
                this["ToastNotificationSecondsPerLine"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public int ToastNotificationAdditionalSeconds {
            get {
                return ((int)(this["ToastNotificationAdditionalSeconds"]));
            }
            set {
                this["ToastNotificationAdditionalSeconds"] = value;
            }
        }
    }
}
