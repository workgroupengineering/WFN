﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wokhan.WindowsFirewallNotifier.Common.Config; 


[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.4.0.0")]
public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
    
    private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
    
    public static Settings Default {
        get {
            return defaultInstance;
        }
    }
    
    [global::System.Configuration.ApplicationScopedSettingAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Configuration.DefaultSettingValueAttribute("True")]
    public bool EnableServiceDetectionGlobal {
        get {
            return ((bool)(this["EnableServiceDetectionGlobal"]));
        }
    }
    
    [global::System.Configuration.UserScopedSettingAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Configuration.DefaultSettingValueAttribute("600")]
    public double ConsoleSizeHeight {
        get {
            return ((double)(this["ConsoleSizeHeight"]));
        }
        set {
            this["ConsoleSizeHeight"] = value;
        }
    }
    
    [global::System.Configuration.UserScopedSettingAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Configuration.DefaultSettingValueAttribute("Normal")]
    public global::System.Windows.WindowState ConsoleState {
        get {
            return ((global::System.Windows.WindowState)(this["ConsoleState"]));
        }
        set {
            this["ConsoleState"] = value;
        }
    }
    
    [global::System.Configuration.UserScopedSettingAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Configuration.DefaultSettingValueAttribute("True")]
    public bool UseAnimation {
        get {
            return ((bool)(this["UseAnimation"]));
        }
        set {
            this["UseAnimation"] = value;
        }
    }
    
    [global::System.Configuration.UserScopedSettingAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Configuration.DefaultSettingValueAttribute("True")]
    public bool FirstRun {
        get {
            return ((bool)(this["FirstRun"]));
        }
        set {
            this["FirstRun"] = value;
        }
    }
    
    [global::System.Configuration.UserScopedSettingAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Configuration.DefaultSettingValueAttribute("False")]
    public bool EnableForAllAccounts {
        get {
            return ((bool)(this["EnableForAllAccounts"]));
        }
        set {
            this["EnableForAllAccounts"] = value;
        }
    }
    
    [global::System.Configuration.ApplicationScopedSettingAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Configuration.DefaultSettingValueAttribute("True")]
    public bool UseBlockRulesGlobal {
        get {
            return ((bool)(this["UseBlockRulesGlobal"]));
        }
    }
    
    [global::System.Configuration.UserScopedSettingAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Configuration.DefaultSettingValueAttribute("0")]
    public int EnableFor {
        get {
            return ((int)(this["EnableFor"]));
        }
        set {
            this["EnableFor"] = value;
        }
    }
    
    [global::System.Configuration.UserScopedSettingAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Configuration.DefaultSettingValueAttribute("True")]
    public bool AlwaysShowDetails {
        get {
            return ((bool)(this["AlwaysShowDetails"]));
        }
        set {
            this["AlwaysShowDetails"] = value;
        }
    }
    
    [global::System.Configuration.UserScopedSettingAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Configuration.DefaultSettingValueAttribute("True")]
    public bool MinimizeToTray {
        get {
            return ((bool)(this["MinimizeToTray"]));
        }
        set {
            this["MinimizeToTray"] = value;
        }
    }
    
    [global::System.Configuration.UserScopedSettingAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Configuration.DefaultSettingValueAttribute("900")]
    public double ConsoleSizeWidth {
        get {
            return ((double)(this["ConsoleSizeWidth"]));
        }
        set {
            this["ConsoleSizeWidth"] = value;
        }
    }
    
    [global::System.Configuration.UserScopedSettingAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Configuration.DefaultSettingValueAttribute("False")]
    public bool EnableVerboseLogging {
        get {
            return ((bool)(this["EnableVerboseLogging"]));
        }
        set {
            this["EnableVerboseLogging"] = value;
        }
    }
    
    [global::System.Configuration.UserScopedSettingAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Configuration.DefaultSettingValueAttribute("True")]
    [global::System.Configuration.SettingsManageabilityAttribute(global::System.Configuration.SettingsManageability.Roaming)]
    public bool AlwaysRunAs {
        get {
            return ((bool)(this["AlwaysRunAs"]));
        }
        set {
            this["AlwaysRunAs"] = value;
        }
    }
    
    [global::System.Configuration.UserScopedSettingAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Configuration.DefaultSettingValueAttribute("True")]
    public bool EnableDnsResolver {
        get {
            return ((bool)(this["EnableDnsResolver"]));
        }
        set {
            this["EnableDnsResolver"] = value;
        }
    }
    
    [global::System.Configuration.UserScopedSettingAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Configuration.DefaultSettingValueAttribute("True")]
    public bool FilterTcpOnlyEvents {
        get {
            return ((bool)(this["FilterTcpOnlyEvents"]));
        }
        set {
            this["FilterTcpOnlyEvents"] = value;
        }
    }
    
    [global::System.Configuration.UserScopedSettingAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Configuration.DefaultSettingValueAttribute("False")]
    public bool AuditPolEnableSuccessEvent {
        get {
            return ((bool)(this["AuditPolEnableSuccessEvent"]));
        }
        set {
            this["AuditPolEnableSuccessEvent"] = value;
        }
    }
    
    [global::System.Configuration.UserScopedSettingAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Configuration.DefaultSettingValueAttribute("https://bgpview.io/ip/{0}")]
    public string TargetInfoUrl {
        get {
            return ((string)(this["TargetInfoUrl"]));
        }
        set {
            this["TargetInfoUrl"] = value;
        }
    }
    
    [global::System.Configuration.UserScopedSettingAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Configuration.DefaultSettingValueAttribute("https://www.speedguide.net/port.php?port={0}")]
    public string TargetPortUrl {
        get {
            return ((string)(this["TargetPortUrl"]));
        }
        set {
            this["TargetPortUrl"] = value;
        }
    }
    
    [global::System.Configuration.UserScopedSettingAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Configuration.DefaultSettingValueAttribute("0,0")]
    public global::System.Windows.Point ActivityWindow_Position {
        get {
            return ((global::System.Windows.Point)(this["ActivityWindow_Position"]));
        }
        set {
            this["ActivityWindow_Position"] = value;
        }
    }
    
    [global::System.Configuration.UserScopedSettingAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Configuration.DefaultSettingValueAttribute("True")]
    public bool ActivityWindow_Shown {
        get {
            return ((bool)(this["ActivityWindow_Shown"]));
        }
        set {
            this["ActivityWindow_Shown"] = value;
        }
    }
    
    [global::System.Configuration.UserScopedSettingAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Configuration.DefaultSettingValueAttribute("Horizontal")]
    public global::System.Windows.Controls.Orientation ActivityWindow_Orientation {
        get {
            return ((global::System.Windows.Controls.Orientation)(this["ActivityWindow_Orientation"]));
        }
        set {
            this["ActivityWindow_Orientation"] = value;
        }
    }
    
    [global::System.Configuration.UserScopedSettingAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Configuration.DefaultSettingValueAttribute("True")]
    public bool StartNotifierAfterLogin {
        get {
            return ((bool)(this["StartNotifierAfterLogin"]));
        }
        set {
            this["StartNotifierAfterLogin"] = value;
        }
    }
    
    [global::System.Configuration.UserScopedSettingAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Configuration.DefaultSettingValueAttribute("True")]
    public bool StartNotifierMinimized {
        get {
            return ((bool)(this["StartNotifierMinimized"]));
        }
        set {
            this["StartNotifierMinimized"] = value;
        }
    }
    
    [global::System.Configuration.UserScopedSettingAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Configuration.DefaultSettingValueAttribute("False")]
    public bool IsInstalled {
        get {
            return ((bool)(this["IsInstalled"]));
        }
        set {
            this["IsInstalled"] = value;
        }
    }
    
    [global::System.Configuration.UserScopedSettingAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Configuration.DefaultSettingValueAttribute("False")]
    public bool IsPortable {
        get {
            return ((bool)(this["IsPortable"]));
        }
        set {
            this["IsPortable"] = value;
        }
    }
    
    [global::System.Configuration.UserScopedSettingAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Configuration.DefaultSettingValueAttribute("False")]
    public bool ShowMap {
        get {
            return ((bool)(this["ShowMap"]));
        }
        set {
            this["ShowMap"] = value;
        }
    }
    
    [global::System.Configuration.UserScopedSettingAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Configuration.DefaultSettingValueAttribute("False")]
    public bool ShowGraph {
        get {
            return ((bool)(this["ShowGraph"]));
        }
        set {
            this["ShowGraph"] = value;
        }
    }
    
    [global::System.Configuration.UserScopedSettingAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Configuration.DefaultSettingValueAttribute("True")]
    public bool ShowConnections {
        get {
            return ((bool)(this["ShowConnections"]));
        }
        set {
            this["ShowConnections"] = value;
        }
    }
    
    [global::System.Configuration.UserScopedSettingAttribute()]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Configuration.DefaultSettingValueAttribute("Automatic")]
    public string Theme {
        get {
            return ((string)(this["Theme"]));
        }
        set {
            this["Theme"] = value;
        }
    }
}
