﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Servidor.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("server=winay.com.ar;User Id=winay_winay; password=R[bZ6)cYq_e5; database=winay_cr" +
            "ecer; port=3306;SSL Mode=0;")]
        public string StringConexionWeb {
            get {
                return ((string)(this["StringConexionWeb"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Initial Catalog=Crecer_3;Persist Security Info=True;User ID=sa;Password=030302;Da" +
            "ta Source=")]
        public string StringConexionNave7 {
            get {
                return ((string)(this["StringConexionNave7"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Initial Catalog=Crecer_4;Persist Security Info=True;User ID=sa;Password=030302;Da" +
            "ta Source=")]
        public string StringConexionVillaMaria {
            get {
                return ((string)(this["StringConexionVillaMaria"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Initial Catalog=Crecer_5;Persist Security Info=True;User ID=sa;Password=030302;Da" +
            "ta Source=")]
        public string StringConexionRioCuarto {
            get {
                return ((string)(this["StringConexionRioCuarto"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Initial Catalog=Crecer_7;Persist Security Info=True;User ID=sa;Password=030302;Da" +
            "ta Source=")]
        public string StringConexionSucursal6 {
            get {
                return ((string)(this["StringConexionSucursal6"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Initial Catalog=Crecer_Unificado;Persist Security Info=True;User ID=sa;Password=0" +
            "30302;Data Source=")]
        public string StringConexionIntegracion {
            get {
                return ((string)(this["StringConexionIntegracion"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Initial Catalog=Crecer_2;Persist Security Info=True;User ID=sa;Password=030302;Da" +
            "ta Source=")]
        public string StringConexionWiki {
            get {
                return ((string)(this["StringConexionWiki"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Initial Catalog=Crecer;Persist Security Info=True;User ID=sa;Password=030302;Data" +
            " Source=")]
        public string StringConexion {
            get {
                return ((string)(this["StringConexion"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Initial Catalog=Guias;Persist Security Info=True;User ID=sa;Password=030302;Data " +
            "Source=")]
        public string StringConexionGuias {
            get {
                return ((string)(this["StringConexionGuias"]));
            }
            set {
                this["StringConexionGuias"] = value;
            }
        }
    }
}
