﻿#pragma checksum "..\..\..\RegistroAdmin.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4D4BBA458088DC58E124C7E23E5C26EDE76DFE1F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using Tienda_Yefell;


namespace Tienda_Yefell {
    
    
    /// <summary>
    /// RegistroAdmin
    /// </summary>
    public partial class RegistroAdmin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\RegistroAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Tienda_Yefell.RegistroAdmin Readmin;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\RegistroAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Nombre;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\RegistroAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Correo;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\RegistroAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Contraseña;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\RegistroAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Registrar;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\RegistroAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Login;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Tienda Yefell;component/registroadmin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\RegistroAdmin.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Readmin = ((Tienda_Yefell.RegistroAdmin)(target));
            return;
            case 2:
            this.Nombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Correo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Contraseña = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Registrar = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\RegistroAdmin.xaml"
            this.Registrar.Click += new System.Windows.RoutedEventHandler(this.Registrar_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Login = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\RegistroAdmin.xaml"
            this.Login.Click += new System.Windows.RoutedEventHandler(this.Login_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

