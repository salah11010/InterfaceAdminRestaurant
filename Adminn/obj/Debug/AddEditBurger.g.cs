﻿#pragma checksum "..\..\AddEditBurger.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4F7890C78C40537D4EEFE5C9E4B34A052E078197B33494EAEA22E7AEF014B9E4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Adminn;
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


namespace Adminn {
    
    
    /// <summary>
    /// AddEditBurger
    /// </summary>
    public partial class AddEditBurger : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 45 "..\..\AddEditBurger.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BurgerNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\AddEditBurger.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BurgerPriceTextBox;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\AddEditBurger.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BurgerImagePathTextBox;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\AddEditBurger.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BurgerSizeTextBox;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\AddEditBurger.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox VegitarienCheckBox;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\AddEditBurger.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox AvibilityCheckBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Adminn;component/addeditburger.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddEditBurger.xaml"
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
            
            #line 27 "..\..\AddEditBurger.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.InterfaceBurger);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BurgerNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.BurgerPriceTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.BurgerImagePathTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.BurgerSizeTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.VegitarienCheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 60 "..\..\AddEditBurger.xaml"
            this.VegitarienCheckBox.Checked += new System.Windows.RoutedEventHandler(this.AvailabilityCheckBox_Checked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.AvibilityCheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 66 "..\..\AddEditBurger.xaml"
            this.AvibilityCheckBox.Checked += new System.Windows.RoutedEventHandler(this.vegetarienCheckBox_Checked);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 69 "..\..\AddEditBurger.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SaveNewEditBurger);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

