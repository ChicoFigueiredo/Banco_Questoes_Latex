﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Componentes_do_Chico.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("D:\\Projetos\\MikTex\\texmfs\\install\\miktex\\bin")]
        public string MikTex_Bin_Folder {
            get {
                return ((string)(this["MikTex_Bin_Folder"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("temp")]
        public string Temp_Folder {
            get {
                return ((string)(this["Temp_Folder"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"\documentclass[preview]{standalone}
\usepackage{ulem}
\usepackage{graphicx}
\usepackage[usenames,dvipsnames,svgnames,table]{xcolor}
\DeclareGraphicsExtensions{.pdf,.png,.jpg}
\usepackage[portuguese]{babel}
\usepackage{pstricks-add}
\usepackage[latin1]{inputenc}
\usepackage{amsmath}
\usepackage{amsfonts}
\usepackage{enumerate}
\usepackage[left=0cm,top=0cm,right=0cm,nohead,nofoot]{geometry}
\geometry{
paperwidth=#PW#cm,
margin=0.5cm
}
\usepackage[light,math]{iwona}
\begin{document} 
")]
        public string Header_Padrao_LATEX {
            get {
                return ((string)(this["Header_Padrao_LATEX"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\\end{document}")]
        public string Footer_Padrao_LATEX {
            get {
                return ((string)(this["Footer_Padrao_LATEX"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("config\\latex_reservade.txt")]
        public string Config_Reservade_Words {
            get {
                return ((string)(this["Config_Reservade_Words"]));
            }
            set {
                this["Config_Reservade_Words"] = value;
            }
        }
    }
}
