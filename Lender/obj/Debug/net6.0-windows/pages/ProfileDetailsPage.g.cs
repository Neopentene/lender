﻿#pragma checksum "..\..\..\..\pages\ProfileDetailsPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8F53A3BA5AF23F6DD45D44DE3E57C0F60A35033D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Lender.UI;
using Lender.pages;
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


namespace Lender.pages {
    
    
    /// <summary>
    /// ProfileDetails
    /// </summary>
    public partial class ProfileDetails : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 31 "..\..\..\..\pages\ProfileDetailsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl Sections;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\..\..\pages\ProfileDetailsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel AddPaymentMessage;
        
        #line default
        #line hidden
        
        
        #line 257 "..\..\..\..\pages\ProfileDetailsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddNewPayment;
        
        #line default
        #line hidden
        
        
        #line 291 "..\..\..\..\pages\ProfileDetailsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel GenerateBreakdownsMessage;
        
        #line default
        #line hidden
        
        
        #line 380 "..\..\..\..\pages\ProfileDetailsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FMonthy;
        
        #line default
        #line hidden
        
        
        #line 384 "..\..\..\..\pages\ProfileDetailsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FQuaterly;
        
        #line default
        #line hidden
        
        
        #line 388 "..\..\..\..\pages\ProfileDetailsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FSemiAnnually;
        
        #line default
        #line hidden
        
        
        #line 392 "..\..\..\..\pages\ProfileDetailsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FAnnually;
        
        #line default
        #line hidden
        
        
        #line 396 "..\..\..\..\pages\ProfileDetailsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FBullet;
        
        #line default
        #line hidden
        
        
        #line 400 "..\..\..\..\pages\ProfileDetailsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GenerateBreakdowns;
        
        #line default
        #line hidden
        
        
        #line 423 "..\..\..\..\pages\ProfileDetailsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GoBack;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.7.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Lender;component/pages/profiledetailspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\pages\ProfileDetailsPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.7.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Sections = ((System.Windows.Controls.TabControl)(target));
            return;
            case 2:
            this.AddPaymentMessage = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            this.AddNewPayment = ((System.Windows.Controls.Button)(target));
            
            #line 268 "..\..\..\..\pages\ProfileDetailsPage.xaml"
            this.AddNewPayment.Click += new System.Windows.RoutedEventHandler(this.AddNewPayment_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.GenerateBreakdownsMessage = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.FMonthy = ((System.Windows.Controls.Button)(target));
            
            #line 382 "..\..\..\..\pages\ProfileDetailsPage.xaml"
            this.FMonthy.Click += new System.Windows.RoutedEventHandler(this.ChangeAmortizationFrequency_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.FQuaterly = ((System.Windows.Controls.Button)(target));
            
            #line 386 "..\..\..\..\pages\ProfileDetailsPage.xaml"
            this.FQuaterly.Click += new System.Windows.RoutedEventHandler(this.ChangeAmortizationFrequency_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.FSemiAnnually = ((System.Windows.Controls.Button)(target));
            
            #line 390 "..\..\..\..\pages\ProfileDetailsPage.xaml"
            this.FSemiAnnually.Click += new System.Windows.RoutedEventHandler(this.ChangeAmortizationFrequency_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.FAnnually = ((System.Windows.Controls.Button)(target));
            
            #line 394 "..\..\..\..\pages\ProfileDetailsPage.xaml"
            this.FAnnually.Click += new System.Windows.RoutedEventHandler(this.ChangeAmortizationFrequency_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.FBullet = ((System.Windows.Controls.Button)(target));
            
            #line 398 "..\..\..\..\pages\ProfileDetailsPage.xaml"
            this.FBullet.Click += new System.Windows.RoutedEventHandler(this.ChangeAmortizationFrequency_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.GenerateBreakdowns = ((System.Windows.Controls.Button)(target));
            
            #line 404 "..\..\..\..\pages\ProfileDetailsPage.xaml"
            this.GenerateBreakdowns.Click += new System.Windows.RoutedEventHandler(this.GenerateBreakdowns_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.GoBack = ((System.Windows.Controls.Button)(target));
            
            #line 431 "..\..\..\..\pages\ProfileDetailsPage.xaml"
            this.GoBack.Click += new System.Windows.RoutedEventHandler(this.GoBack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.7.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 3:
            
            #line 228 "..\..\..\..\pages\ProfileDetailsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeletePayment_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}
