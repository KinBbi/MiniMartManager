﻿#pragma checksum "..\..\..\..\Form\frmNhanVien.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6BF8E281C793B0318E0629CF7630FD21C7BF015E"
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
    /// frmNhanVien
    /// </summary>
    public partial class frmNhanVien : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\..\Form\frmNhanVien.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMaNv;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Form\frmNhanVien.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTenNv;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\Form\frmNhanVien.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSdt;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\Form\frmNhanVien.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtGioiTinh;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\Form\frmNhanVien.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnXoaNv;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\..\Form\frmNhanVien.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCapNhatNv;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\Form\frmNhanVien.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgNhanVien;
        
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
            System.Uri resourceLocater = new System.Uri("/quanlibanhang;component/form/frmnhanvien.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Form\frmNhanVien.xaml"
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
            this.txtMaNv = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtTenNv = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtSdt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtGioiTinh = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            
            #line 77 "..\..\..\..\Form\frmNhanVien.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ThemNv_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnXoaNv = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\..\..\Form\frmNhanVien.xaml"
            this.btnXoaNv.Click += new System.Windows.RoutedEventHandler(this.btnXoaNv_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnCapNhatNv = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\..\..\Form\frmNhanVien.xaml"
            this.btnCapNhatNv.Click += new System.Windows.RoutedEventHandler(this.btnCapNhatNv_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.dgNhanVien = ((System.Windows.Controls.DataGrid)(target));
            
            #line 82 "..\..\..\..\Form\frmNhanVien.xaml"
            this.dgNhanVien.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgNhanVien_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

