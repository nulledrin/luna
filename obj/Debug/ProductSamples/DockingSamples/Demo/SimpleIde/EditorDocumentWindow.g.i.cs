﻿#pragma checksum "..\..\..\..\..\..\ProductSamples\DockingSamples\Demo\SimpleIde\EditorDocumentWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FA8F95DF20631D1C85079B89133E6B82A602D2B46031D7EC79C5408AEC631564"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ActiproSoftware.Products.Docking;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Implementation;
using ActiproSoftware.Text.Languages.CSharp.Implementation;
using ActiproSoftware.Text.Languages.JavaScript.Implementation;
using ActiproSoftware.Text.Languages.Python.Implementation;
using ActiproSoftware.Text.Languages.VB.Implementation;
using ActiproSoftware.Text.Languages.Xml.Implementation;
using ActiproSoftware.Windows.Controls.Docking;
using ActiproSoftware.Windows.Controls.Docking.Primitives;
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


namespace ActiproSoftware.ProductSamples.DockingSamples.Demo.SimpleIde {
    
    
    /// <summary>
    /// EditorDocumentWindow
    /// </summary>
    public partial class EditorDocumentWindow : ActiproSoftware.Windows.Controls.Docking.DocumentWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\..\..\..\ProductSamples\DockingSamples\Demo\SimpleIde\EditorDocumentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border symbolSelectorBorder;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\..\..\ProductSamples\DockingSamples\Demo\SimpleIde\EditorDocumentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ActiproSoftware.Windows.Controls.SyntaxEditor.NavigableSymbolSelector symbolSelector;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\..\..\ProductSamples\DockingSamples\Demo\SimpleIde\EditorDocumentWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ActiproSoftware.Windows.Controls.SyntaxEditor.SyntaxEditor editor;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp3;component/productsamples/dockingsamples/demo/simpleide/editordocumentwin" +
                    "dow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\ProductSamples\DockingSamples\Demo\SimpleIde\EditorDocumentWindow.xaml"
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
            this.symbolSelectorBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 2:
            this.symbolSelector = ((ActiproSoftware.Windows.Controls.SyntaxEditor.NavigableSymbolSelector)(target));
            return;
            case 3:
            this.editor = ((ActiproSoftware.Windows.Controls.SyntaxEditor.SyntaxEditor)(target));
            
            #line 21 "..\..\..\..\..\..\ProductSamples\DockingSamples\Demo\SimpleIde\EditorDocumentWindow.xaml"
            this.editor.DocumentIsModifiedChanged += new System.Windows.RoutedEventHandler(this.OnEditorDocumentIsModifiedChanged);
            
            #line default
            #line hidden
            
            #line 22 "..\..\..\..\..\..\ProductSamples\DockingSamples\Demo\SimpleIde\EditorDocumentWindow.xaml"
            this.editor.DocumentParseDataChanged += new System.Windows.RoutedEventHandler(this.OnEditorDocumentParseDataChanged);
            
            #line default
            #line hidden
            
            #line 23 "..\..\..\..\..\..\ProductSamples\DockingSamples\Demo\SimpleIde\EditorDocumentWindow.xaml"
            this.editor.ViewSearch += new System.EventHandler<ActiproSoftware.Windows.Controls.SyntaxEditor.EditorViewSearchEventArgs>(this.OnEditorViewSearch);
            
            #line default
            #line hidden
            
            #line 24 "..\..\..\..\..\..\ProductSamples\DockingSamples\Demo\SimpleIde\EditorDocumentWindow.xaml"
            this.editor.UserInterfaceUpdate += new System.Windows.RoutedEventHandler(this.OnEditorUserInterfaceUpdate);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

