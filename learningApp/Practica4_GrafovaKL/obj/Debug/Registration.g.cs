﻿#pragma checksum "..\..\Registration.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8E1781788CE17E09C0956C28AFC56A5A6BDD7CEF2BE80A93A243B36BB6BE22AA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Practica4_GrafovaKL;
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


namespace Practica4_GrafovaKL {
    
    
    /// <summary>
    /// Registration
    /// </summary>
    public partial class Registration : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 60 "..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Login;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock HintLogin;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextShowPassword;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Password;
        
        #line default
        #line hidden
        
        
        #line 161 "..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock HintPassword;
        
        #line default
        #line hidden
        
        
        #line 164 "..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PassowordShowOrHide;
        
        #line default
        #line hidden
        
        
        #line 180 "..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox email;
        
        #line default
        #line hidden
        
        
        #line 198 "..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock HintEmail;
        
        #line default
        #line hidden
        
        
        #line 208 "..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Female;
        
        #line default
        #line hidden
        
        
        #line 222 "..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Male;
        
        #line default
        #line hidden
        
        
        #line 237 "..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RegistrationButton;
        
        #line default
        #line hidden
        
        
        #line 286 "..\..\Registration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackToSignIn;
        
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
            System.Uri resourceLocater = new System.Uri("/Practica4_GrafovaKL;component/registration.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Registration.xaml"
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
            
            #line 40 "..\..\Registration.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Cancel_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Login = ((System.Windows.Controls.TextBox)(target));
            
            #line 62 "..\..\Registration.xaml"
            this.Login.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Login_TextChanged);
            
            #line default
            #line hidden
            
            #line 65 "..\..\Registration.xaml"
            this.Login.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Login_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 65 "..\..\Registration.xaml"
            this.Login.LostFocus += new System.Windows.RoutedEventHandler(this.Login_LostFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.HintLogin = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.TextShowPassword = ((System.Windows.Controls.TextBox)(target));
            
            #line 106 "..\..\Registration.xaml"
            this.TextShowPassword.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextShowPassword_TextChanged);
            
            #line default
            #line hidden
            
            #line 108 "..\..\Registration.xaml"
            this.TextShowPassword.LostFocus += new System.Windows.RoutedEventHandler(this.TextShowPassword_LostFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Password = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 126 "..\..\Registration.xaml"
            this.Password.LostFocus += new System.Windows.RoutedEventHandler(this.Password_LostFocus);
            
            #line default
            #line hidden
            
            #line 127 "..\..\Registration.xaml"
            this.Password.PasswordChanged += new System.Windows.RoutedEventHandler(this.Password_PasswordChanged);
            
            #line default
            #line hidden
            
            #line 128 "..\..\Registration.xaml"
            this.Password.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Password_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 6:
            this.HintPassword = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.PassowordShowOrHide = ((System.Windows.Controls.Button)(target));
            
            #line 168 "..\..\Registration.xaml"
            this.PassowordShowOrHide.Click += new System.Windows.RoutedEventHandler(this.ButtonPass_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.email = ((System.Windows.Controls.TextBox)(target));
            
            #line 182 "..\..\Registration.xaml"
            this.email.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Email_TextChanged);
            
            #line default
            #line hidden
            
            #line 184 "..\..\Registration.xaml"
            this.email.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Email_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 185 "..\..\Registration.xaml"
            this.email.LostFocus += new System.Windows.RoutedEventHandler(this.Email_LostFocus);
            
            #line default
            #line hidden
            return;
            case 9:
            this.HintEmail = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.Female = ((System.Windows.Controls.RadioButton)(target));
            
            #line 209 "..\..\Registration.xaml"
            this.Female.Checked += new System.Windows.RoutedEventHandler(this.RadioButton1_Checked);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Male = ((System.Windows.Controls.RadioButton)(target));
            
            #line 222 "..\..\Registration.xaml"
            this.Male.Checked += new System.Windows.RoutedEventHandler(this.Male_Checked);
            
            #line default
            #line hidden
            return;
            case 12:
            this.RegistrationButton = ((System.Windows.Controls.Button)(target));
            
            #line 239 "..\..\Registration.xaml"
            this.RegistrationButton.Click += new System.Windows.RoutedEventHandler(this.RegistrationButton_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.BackToSignIn = ((System.Windows.Controls.Button)(target));
            
            #line 287 "..\..\Registration.xaml"
            this.BackToSignIn.Click += new System.Windows.RoutedEventHandler(this.BackToSignIn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

