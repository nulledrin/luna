﻿#pragma checksum "..\..\..\..\..\..\ProductSamples\EditorsSamples\QuickStart\TimePickerIntro\MainControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F3874875FA5B222C27A800C4A564981234F45DCF0C7741F3ED77A384FEC72A2A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ActiproSoftware.Products.Editors;
using ActiproSoftware.Products.Shared;
using ActiproSoftware.SampleBrowser;
using ActiproSoftware.Windows;
using ActiproSoftware.Windows.Controls;
using ActiproSoftware.Windows.Controls.ColorSelection;
using ActiproSoftware.Windows.Controls.Editors;
using ActiproSoftware.Windows.Controls.Editors.Primitives;
using ActiproSoftware.Windows.Controls.Primitives;
using ActiproSoftware.Windows.Controls.Rendering;
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


namespace ActiproSoftware.ProductSamples.EditorsSamples.QuickStart.TimePickerIntro {
    
    
    /// <summary>
    /// MainControl
    /// </summary>
    public partial class MainControl : ActiproSoftware.SampleBrowser.ProductItemControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\..\..\..\..\ProductSamples\EditorsSamples\QuickStart\TimePickerIntro\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ActiproSoftware.Windows.Controls.Editors.TimePicker picker;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp3;component/productsamples/editorssamples/quickstart/timepickerintro/mainc" +
                    "ontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\ProductSamples\EditorsSamples\QuickStart\TimePickerIntro\MainControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.picker = ((ActiproSoftware.Windows.Controls.Editors.TimePicker)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

