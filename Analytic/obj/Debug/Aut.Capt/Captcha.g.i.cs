﻿#pragma checksum "..\..\..\Aut.Capt\Captcha.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F17D97FE4B1602C32DC84A87D87C955F802FF854883F2DC35F8279936E5E8660"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Analytic.Aut.Capt;
using EasyCaptcha.Wpf;
using FontAwesome.Sharp;
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


namespace Analytic.Aut.Capt {
    
    
    /// <summary>
    /// Captcha
    /// </summary>
    public partial class Captcha : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 45 "..\..\..\Aut.Capt\Captcha.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\Aut.Capt\Captcha.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Cpt_Change;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\Aut.Capt\Captcha.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal EasyCaptcha.Wpf.Captcha Captcha1;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\Aut.Capt\Captcha.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Cmb;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\Aut.Capt\Captcha.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock AnswerTextBlock;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\Aut.Capt\Captcha.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Cpt;
        
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
            System.Uri resourceLocater = new System.Uri("/Analytic;component/aut.capt/captcha.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Aut.Capt\Captcha.xaml"
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
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\Aut.Capt\Captcha.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Cpt_Change = ((System.Windows.Controls.Button)(target));
            
            #line 74 "..\..\..\Aut.Capt\Captcha.xaml"
            this.Cpt_Change.Click += new System.Windows.RoutedEventHandler(this.Cpt_Change_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Captcha1 = ((EasyCaptcha.Wpf.Captcha)(target));
            return;
            case 4:
            this.Cmb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.AnswerTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.Cpt = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\..\Aut.Capt\Captcha.xaml"
            this.Cpt.Click += new System.Windows.RoutedEventHandler(this.Cpt_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

