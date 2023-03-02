﻿#pragma checksum "..\..\..\..\..\SampleBrowser\Utilities\StringResourceBrowser\MainControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D61A2850727E51507DA301AFA8B5DD42E74CF3215DAE8A98565DB6758FA2C5BE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.SampleBrowser;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Implementation;
using ActiproSoftware.Text.Languages.CSharp.Implementation;
using ActiproSoftware.Text.Languages.JavaScript.Implementation;
using ActiproSoftware.Text.Languages.Python.Implementation;
using ActiproSoftware.Text.Languages.VB.Implementation;
using ActiproSoftware.Text.Languages.Xml.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Dialogs;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;
using ActiproSoftware.Windows.Themes;
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


namespace ActiproSoftware.SampleBrowser.Utilities.StringResourceBrowser {
    
    
    /// <summary>
    /// MainControl
    /// </summary>
    public partial class MainControl : ActiproSoftware.SampleBrowser.ProductItemControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\..\SampleBrowser\Utilities\StringResourceBrowser\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox customValueTextBox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\..\SampleBrowser\Utilities\StringResourceBrowser\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ActiproSoftware.Windows.Controls.SyntaxEditor.SyntaxEditor resultEditor;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\..\SampleBrowser\Utilities\StringResourceBrowser\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox productComboBox;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\..\SampleBrowser\Utilities\StringResourceBrowser\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView resourcesListView;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp3;component/samplebrowser/utilities/stringresourcebrowser/maincontrol.xaml" +
                    "", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\SampleBrowser\Utilities\StringResourceBrowser\MainControl.xaml"
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
            this.customValueTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\..\..\..\SampleBrowser\Utilities\StringResourceBrowser\MainControl.xaml"
            this.customValueTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnCustomValueTextBoxTextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.resultEditor = ((ActiproSoftware.Windows.Controls.SyntaxEditor.SyntaxEditor)(target));
            return;
            case 3:
            this.productComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 52 "..\..\..\..\..\SampleBrowser\Utilities\StringResourceBrowser\MainControl.xaml"
            this.productComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.OnProductComboBoxSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.resourcesListView = ((System.Windows.Controls.ListView)(target));
            
            #line 56 "..\..\..\..\..\SampleBrowser\Utilities\StringResourceBrowser\MainControl.xaml"
            this.resourcesListView.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.OnResourcesListViewSelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

