﻿#pragma checksum "..\..\..\Edit\New_Plan_Week.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "703507E44D011DAD2EF431D978FE609D7B34356F4E22227026B825C9D249D15B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Analytic.Edit;
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


namespace Analytic.Edit {
    
    
    /// <summary>
    /// New_Plan_Week
    /// </summary>
    public partial class New_Plan_Week : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 51 "..\..\..\Edit\New_Plan_Week.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\Edit\New_Plan_Week.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox WWeek_Nomenclature;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\Edit\New_Plan_Week.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox WWeek_Volume;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\Edit\New_Plan_Week.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox WWeek_Note;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\Edit\New_Plan_Week.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Week;
        
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
            System.Uri resourceLocater = new System.Uri("/Analytic;component/edit/new_plan_week.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Edit\New_Plan_Week.xaml"
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
            
            #line 54 "..\..\..\Edit\New_Plan_Week.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.WWeek_Nomenclature = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.WWeek_Volume = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.WWeek_Note = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Week = ((System.Windows.Controls.Button)(target));
            
            #line 87 "..\..\..\Edit\New_Plan_Week.xaml"
            this.Week.Click += new System.Windows.RoutedEventHandler(this.Week_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

