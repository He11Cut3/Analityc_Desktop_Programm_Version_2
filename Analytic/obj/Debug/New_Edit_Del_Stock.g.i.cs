﻿#pragma checksum "..\..\New_Edit_Del_Stock.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D861FCB1D5F68DAA40D0B9A2E716C15545911040C3D7AB7572A01AA6F4B46B08"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Analytic;
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


namespace Analytic {
    
    
    /// <summary>
    /// New_Edit_Del_Stock
    /// </summary>
    public partial class New_Edit_Del_Stock : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 62 "..\..\New_Edit_Del_Stock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox GGroup_Surname;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\New_Edit_Del_Stock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox GGroup_name;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\New_Edit_Del_Stock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox GGroup_Partonymic;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\New_Edit_Del_Stock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox GGroup_Phone;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\New_Edit_Del_Stock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox GGroup_Email;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\New_Edit_Del_Stock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LV_User_Grid;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\New_Edit_Del_Stock.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Material;
        
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
            System.Uri resourceLocater = new System.Uri("/Analytic;component/new_edit_del_stock.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\New_Edit_Del_Stock.xaml"
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
            this.GGroup_Surname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.GGroup_name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.GGroup_Partonymic = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.GGroup_Phone = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.GGroup_Email = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.LV_User_Grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.Material = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\New_Edit_Del_Stock.xaml"
            this.Material.Click += new System.Windows.RoutedEventHandler(this.New_Material_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

