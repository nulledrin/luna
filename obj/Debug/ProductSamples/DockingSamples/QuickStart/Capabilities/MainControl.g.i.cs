﻿#pragma checksum "..\..\..\..\..\..\ProductSamples\DockingSamples\QuickStart\Capabilities\MainControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E5A87310EC0EB3F97D1256444A7A6EE96B25781BB886BE3EC19308E7E4595CCA"
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
using ActiproSoftware.SampleBrowser;
using ActiproSoftware.Windows.Controls.Docking;
using ActiproSoftware.Windows.Controls.Docking.Primitives;
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


namespace ActiproSoftware.ProductSamples.DockingSamples.QuickStart.Capabilities {
    
    
    /// <summary>
    /// MainControl
    /// </summary>
    public partial class MainControl : ActiproSoftware.SampleBrowser.ProductItemControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\..\..\..\ProductSamples\DockingSamples\QuickStart\Capabilities\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ActiproSoftware.Windows.Controls.Docking.DockSite dockSite;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\..\..\ProductSamples\DockingSamples\QuickStart\Capabilities\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ActiproSoftware.Windows.Controls.Docking.TabbedMdiHost tabbedMdiHost;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\..\..\ProductSamples\DockingSamples\QuickStart\Capabilities\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ActiproSoftware.Windows.Controls.Docking.DocumentWindow documentWindow;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\..\..\..\ProductSamples\DockingSamples\QuickStart\Capabilities\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ActiproSoftware.Windows.Controls.Docking.ToolWindow toolWindow;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp3;component/productsamples/dockingsamples/quickstart/capabilities/maincont" +
                    "rol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\ProductSamples\DockingSamples\QuickStart\Capabilities\MainControl.xaml"
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
            this.dockSite = ((ActiproSoftware.Windows.Controls.Docking.DockSite)(target));
            return;
            case 2:
            this.tabbedMdiHost = ((ActiproSoftware.Windows.Controls.Docking.TabbedMdiHost)(target));
            return;
            case 3:
            this.documentWindow = ((ActiproSoftware.Windows.Controls.Docking.DocumentWindow)(target));
            return;
            case 4:
            this.toolWindow = ((ActiproSoftware.Windows.Controls.Docking.ToolWindow)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

