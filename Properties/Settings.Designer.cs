﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Reactor.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.6.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("HH:mm:ss.ffffff")]
        public string TimestampFormat {
            get {
                return ((string)(this["TimestampFormat"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2000")]
        public string PollInterval {
            get {
                return ((string)(this["PollInterval"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://neurul.ngrok.io")]
        public string NotificationLogBaseUrl {
            get {
                return ((string)(this["NotificationLogBaseUrl"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("8c4df9d3-9fc8-4377-b43d-4db544abc9f2")]
        public string AnalyzedId {
            get {
                return ((string)(this["AnalyzedId"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("heartrate")]
        public string AvatarUri {
            get {
                return ((string)(this["AvatarUri"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("fc32f33a-7115-4eee-853e-fbcc10dbf09f, 36ebff6d-5b8b-4819-b71d-ffab7dc6e035")]
        public string SpikeTargets {
            get {
                return ((string)(this["SpikeTargets"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2f695b78-ebb1-442d-a653-38b3ca3a32d1, 17c6ea5b-62a3-4c38-a044-b67957162211, dece2" +
            "a11-a4ae-4f06-a90a-ac350dd77521")]
        public string ResultMarkers {
            get {
                return ((string)(this["ResultMarkers"]));
            }
        }
    }
}