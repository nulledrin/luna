﻿#pragma checksum "..\..\..\..\..\..\ProductSamples\SyntaxEditorSamples\QuickStart\GettingStarted09\MainControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D0E8AF0C69B9CA4632992BA62A91460BFD1FEA4F19461B73A8C49D26CD2CA11F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ActiproSoftware.ProductSamples.SyntaxEditorSamples.QuickStart.GettingStarted09;
using ActiproSoftware.Products.Docking;
using ActiproSoftware.Products.Shared;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Implementation;
using ActiproSoftware.Text.Languages.CSharp.Implementation;
using ActiproSoftware.Text.Languages.JavaScript.Implementation;
using ActiproSoftware.Text.Languages.Python.Implementation;
using ActiproSoftware.Text.Languages.VB.Implementation;
using ActiproSoftware.Text.Languages.Xml.Implementation;
using ActiproSoftware.Windows;
using ActiproSoftware.Windows.Controls;
using ActiproSoftware.Windows.Controls.ColorSelection;
using ActiproSoftware.Windows.Controls.Docking;
using ActiproSoftware.Windows.Controls.Docking.Primitives;
using ActiproSoftware.Windows.Controls.Primitives;
using ActiproSoftware.Windows.Controls.Rendering;
using ActiproSoftware.Windows.Controls.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Dialogs;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;
using ActiproSoftware.Windows.Data;
using ActiproSoftware.Windows.Data.Filtering;
using ActiproSoftware.Windows.DocumentManagement;
using ActiproSoftware.Windows.Input;
using ActiproSoftware.Windows.Media;
using ActiproSoftware.Windows.Media.Animation;
using ActiproSoftware.Windows.Shapes;
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


namespace ActiproSoftware.ProductSamples.SyntaxEditorSamples.QuickStart.GettingStarted09 {
    
    
    /// <summary>
    /// MainControl
    /// </summary>
    public partial class MainControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\..\..\..\ProductSamples\SyntaxEditorSamples\QuickStart\GettingStarted09\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ActiproSoftware.Windows.Controls.SyntaxEditor.SyntaxEditor editor;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\..\..\ProductSamples\SyntaxEditorSamples\QuickStart\GettingStarted09\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView errorListView;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp3;component/productsamples/syntaxeditorsamples/quickstart/gettingstarted09" +
                    "/maincontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\ProductSamples\SyntaxEditorSamples\QuickStart\GettingStarted09\MainControl.xaml"
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
            this.editor = ((ActiproSoftware.Windows.Controls.SyntaxEditor.SyntaxEditor)(target));
            
            #line 34 "..\..\..\..\..\..\ProductSamples\SyntaxEditorSamples\QuickStart\GettingStarted09\MainControl.xaml"
            this.editor.DocumentParseDataChanged += new System.Windows.RoutedEventHandler(this.OnEditorDocumentParseDataChanged);
            
            #line default
            #line hidden
            
            #line 35 "..\..\..\..\..\..\ProductSamples\SyntaxEditorSamples\QuickStart\GettingStarted09\MainControl.xaml"
            this.editor.UserInterfaceUpdate += new System.Windows.RoutedEventHandler(this.OnEditorUserInterfaceUpdate);
            
            #line default
            #line hidden
            return;
            case 2:
            this.errorListView = ((System.Windows.Controls.ListView)(target));
            
            #line 72 "..\..\..\..\..\..\ProductSamples\SyntaxEditorSamples\QuickStart\GettingStarted09\MainControl.xaml"
            this.errorListView.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.OnErrorListViewDoubleClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

