﻿#pragma checksum "..\..\..\..\Form\frmSanPham.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27B68E13C3D80AECE23A1C4D5F60BF9F1C5AD1FC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using quanlibanhang.Form;


namespace quanlibanhang.Form {
    
    
    /// <summary>
    /// frmSanPham
    /// </summary>
    public partial class frmSanPham : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\..\Form\frmSanPham.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnXoaSp;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Form\frmSanPham.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbLoaiSp;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\Form\frmSanPham.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLocSp;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\Form\frmSanPham.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid SanphamDataGrid;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/quanlibanhang;V1.0.0.0;component/form/frmsanpham.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Form\frmSanPham.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 24 "..\..\..\..\Form\frmSanPham.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.themSp_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnXoaSp = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\..\Form\frmSanPham.xaml"
            this.btnXoaSp.Click += new System.Windows.RoutedEventHandler(this.btnXoaSp_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 36 "..\..\..\..\Form\frmSanPham.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UpdateDL_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cbLoaiSp = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.btnLocSp = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\..\Form\frmSanPham.xaml"
            this.btnLocSp.Click += new System.Windows.RoutedEventHandler(this.btnLocSp_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.SanphamDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 60 "..\..\..\..\Form\frmSanPham.xaml"
            this.SanphamDataGrid.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.SuaSP_Click);
            
            #line default
            #line hidden
            
            #line 62 "..\..\..\..\Form\frmSanPham.xaml"
            this.SanphamDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SanphamDataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

