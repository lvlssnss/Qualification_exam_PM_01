﻿#pragma checksum "..\..\..\User_Contols\UC_Banners.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3455CB34C0ACCEAB35FDC9BE06796B918F414CDCA1546D24D360FC3AD3EED0A2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using BANer.User_Contols;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace BANer.User_Contols {
    
    
    /// <summary>
    /// UC_Banners
    /// </summary>
    public partial class UC_Banners : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 22 "..\..\..\User_Contols\UC_Banners.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button New_User;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\User_Contols\UC_Banners.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Filt_Post;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\User_Contols\UC_Banners.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Sort_Name;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\User_Contols\UC_Banners.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox value;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\User_Contols\UC_Banners.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LV_Users;
        
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
            System.Uri resourceLocater = new System.Uri("/BANer;component/user_contols/uc_banners.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\User_Contols\UC_Banners.xaml"
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
            this.New_User = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\User_Contols\UC_Banners.xaml"
            this.New_User.Click += new System.Windows.RoutedEventHandler(this.New_User_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Filt_Post = ((System.Windows.Controls.ComboBox)(target));
            
            #line 30 "..\..\..\User_Contols\UC_Banners.xaml"
            this.Filt_Post.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Filt_Post_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Sort_Name = ((System.Windows.Controls.ComboBox)(target));
            
            #line 33 "..\..\..\User_Contols\UC_Banners.xaml"
            this.Sort_Name.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Sort_Name_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.value = ((System.Windows.Controls.ComboBox)(target));
            
            #line 37 "..\..\..\User_Contols\UC_Banners.xaml"
            this.value.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.value_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.LV_Users = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 6:
            
            #line 93 "..\..\..\User_Contols\UC_Banners.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Edit_del_Order_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

