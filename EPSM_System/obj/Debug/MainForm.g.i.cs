﻿#pragma checksum "..\..\MainForm.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C5487423FAFD16EECACCFF523706DB0073DE1D96"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using EPSM_System;
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


namespace EPSM_System {
    
    
    /// <summary>
    /// MainForm
    /// </summary>
    public partial class MainForm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\MainForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu mainMenu;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\MainForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenuRecord;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\MainForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenuBonus;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\MainForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenuAttendance;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\MainForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenuPay;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\MainForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenuReport;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\MainForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame frame1;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\MainForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbLoginName;
        
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
            System.Uri resourceLocater = new System.Uri("/EPSM_System;component/mainform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainForm.xaml"
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
            
            #line 8 "..\..\MainForm.xaml"
            ((EPSM_System.MainForm)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.mainMenu = ((System.Windows.Controls.Menu)(target));
            return;
            case 3:
            this.MenuRecord = ((System.Windows.Controls.MenuItem)(target));
            
            #line 16 "..\..\MainForm.xaml"
            this.MenuRecord.Click += new System.Windows.RoutedEventHandler(this.MenuRecord_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MenuBonus = ((System.Windows.Controls.MenuItem)(target));
            
            #line 18 "..\..\MainForm.xaml"
            this.MenuBonus.Click += new System.Windows.RoutedEventHandler(this.MenuBonus_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.MenuAttendance = ((System.Windows.Controls.MenuItem)(target));
            
            #line 20 "..\..\MainForm.xaml"
            this.MenuAttendance.Click += new System.Windows.RoutedEventHandler(this.MenuAttendance_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.MenuPay = ((System.Windows.Controls.MenuItem)(target));
            
            #line 22 "..\..\MainForm.xaml"
            this.MenuPay.Click += new System.Windows.RoutedEventHandler(this.MenuPay_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.MenuReport = ((System.Windows.Controls.MenuItem)(target));
            
            #line 24 "..\..\MainForm.xaml"
            this.MenuReport.Click += new System.Windows.RoutedEventHandler(this.MenuReport_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 27 "..\..\MainForm.xaml"
            ((System.Windows.Controls.DockPanel)(target)).Loaded += new System.Windows.RoutedEventHandler(this.DockPanel_Loaded);
            
            #line default
            #line hidden
            return;
            case 9:
            this.frame1 = ((System.Windows.Controls.Frame)(target));
            return;
            case 10:
            this.tbLoginName = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

