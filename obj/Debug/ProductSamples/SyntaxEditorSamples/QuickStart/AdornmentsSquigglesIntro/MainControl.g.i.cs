﻿#pragma checksum "..\..\..\..\..\..\ProductSamples\SyntaxEditorSamples\QuickStart\AdornmentsSquigglesIntro\MainControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BF40E914BD36879379A73EEAED2EC4A3AB0E6B6661AA1676048E0967427770F0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ActiproSoftware.ProductSamples.SyntaxEditorSamples.QuickStart.AdornmentsSquigglesIntro;
using ActiproSoftware.Products.SyntaxEditor;
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


namespace ActiproSoftware.ProductSamples.SyntaxEditorSamples.QuickStart.AdornmentsSquigglesIntro {
    
    
    /// <summary>
    /// MainControl
    /// </summary>
    public partial class MainControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\..\..\..\ProductSamples\SyntaxEditorSamples\QuickStart\AdornmentsSquigglesIntro\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ActiproSoftware.Windows.Controls.SyntaxEditor.SyntaxEditor editor;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\..\..\..\ProductSamples\SyntaxEditorSamples\QuickStart\AdornmentsSquigglesIntro\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ActiproSoftware.Text.Implementation.EditorDocument document;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp3;component/productsamples/syntaxeditorsamples/quickstart/adornmentssquigg" +
                    "lesintro/maincontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\ProductSamples\SyntaxEditorSamples\QuickStart\AdornmentsSquigglesIntro\MainControl.xaml"
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
            return;
            case 2:
            this.document = ((ActiproSoftware.Text.Implementation.EditorDocument)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
