﻿#pragma checksum "..\..\..\..\Form\frmThemSP1.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02C0AED1FBDBFC0DE4B522BBBF7790FF5606E44A"
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
    /// ThemSp
    /// </summary>
    public partial class ThemSp : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\..\Form\frmThemSP1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Masptextbox;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Form\frmThemSP1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTenSp;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Form\frmThemSP1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSoLuong;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\Form\frmThemSP1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtGiaNhap;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\Form\frmThemSP1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtGiaBan;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\..\Form\frmThemSP1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker txtNgayNhap;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\..\Form\frmThemSP1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtLoaiHang;
        
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
            System.Uri resourceLocater = new System.Uri("/quanlibanhang;component/form/frmthemsp1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Form\frmThemSP1.xaml"
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
            this.Masptextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtTenSp = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtSoLuong = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtGiaNhap = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtGiaBan = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtNgayNhap = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.txtLoaiHang = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 122 "..\..\..\..\Form\frmThemSP1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LuuSp_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

