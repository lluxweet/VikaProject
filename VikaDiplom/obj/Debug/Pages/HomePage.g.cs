﻿#pragma checksum "..\..\..\Pages\HomePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1C33DBD574A3B98B2A1E389B837C55F976DD40EAB518FA38B8F7F4F401A7AB95"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
using VikaDiplom.Pages;


namespace VikaDiplom.Pages {
    
    
    /// <summary>
    /// HomePage
    /// </summary>
    public partial class HomePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\Pages\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btxExit;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Pages\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnchild;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Pages\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOpeca;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Pages\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnApp;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Pages\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame frame;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/VikaDiplom;component/pages/homepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\HomePage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btxExit = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\Pages\HomePage.xaml"
            this.btxExit.Click += new System.Windows.RoutedEventHandler(this.btxExit_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnchild = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\Pages\HomePage.xaml"
            this.btnchild.Click += new System.Windows.RoutedEventHandler(this.btnchild_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnOpeca = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Pages\HomePage.xaml"
            this.btnOpeca.Click += new System.Windows.RoutedEventHandler(this.btnOpeca_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnApp = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Pages\HomePage.xaml"
            this.btnApp.Click += new System.Windows.RoutedEventHandler(this.btnApp_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.frame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

