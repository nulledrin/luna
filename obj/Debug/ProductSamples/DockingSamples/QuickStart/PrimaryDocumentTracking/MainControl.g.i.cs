﻿#pragma checksum "..\..\..\..\..\..\ProductSamples\DockingSamples\QuickStart\PrimaryDocumentTracking\MainControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2419C6F592FC500AA4FF008249D93A7C3DA511FD314E414B18C267E6365B9C82"
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
using ActiproSoftware.Products.Shared;
using ActiproSoftware.SampleBrowser;
using ActiproSoftware.Windows;
using ActiproSoftware.Windows.Controls;
using ActiproSoftware.Windows.Controls.ColorSelection;
using ActiproSoftware.Windows.Controls.Docking;
using ActiproSoftware.Windows.Controls.Docking.Primitives;
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


namespace ActiproSoftware.ProductSamples.DockingSamples.QuickStart.PrimaryDocumentTracking {
    
    
    /// <summary>
    /// MainControl
    /// </summary>
    public partial class MainControl : ActiproSoftware.SampleBrowser.ProductItemControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 66 "..\..\..\..\..\..\ProductSamples\DockingSamples\QuickStart\PrimaryDocumentTracking\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ActiproSoftware.Windows.Controls.Docking.DockSite dockSite;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\..\..\..\ProductSamples\DockingSamples\QuickStart\PrimaryDocumentTracking\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock primaryDocumentTextBlock;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\..\..\..\..\ProductSamples\DockingSamples\QuickStart\PrimaryDocumentTracking\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock activeWindowTextBlock;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp3;component/productsamples/dockingsamples/quickstart/primarydocumenttracki" +
                    "ng/maincontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\ProductSamples\DockingSamples\QuickStart\PrimaryDocumentTracking\MainControl.xaml"
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
            
            #line 41 "..\..\..\..\..\..\ProductSamples\DockingSamples\QuickStart\PrimaryDocumentTracking\MainControl.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.OnNewDocumentMenuItemClick);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 42 "..\..\..\..\..\..\ProductSamples\DockingSamples\QuickStart\PrimaryDocumentTracking\MainControl.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.OnOpenDocumentMenuItemClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dockSite = ((ActiproSoftware.Windows.Controls.Docking.DockSite)(target));
            
            #line 67 "..\..\..\..\..\..\ProductSamples\DockingSamples\QuickStart\PrimaryDocumentTracking\MainControl.xaml"
            this.dockSite.WindowActivated += new System.EventHandler<ActiproSoftware.Windows.Controls.Docking.DockingWindowEventArgs>(this.OnDockSiteWindowActivated);
            
            #line default
            #line hidden
            
            #line 68 "..\..\..\..\..\..\ProductSamples\DockingSamples\QuickStart\PrimaryDocumentTracking\MainControl.xaml"
            this.dockSite.WindowDeactivated += new System.EventHandler<ActiproSoftware.Windows.Controls.Docking.DockingWindowEventArgs>(this.OnDockSiteWindowDeactivated);
            
            #line default
            #line hidden
            
            #line 69 "..\..\..\..\..\..\ProductSamples\DockingSamples\QuickStart\PrimaryDocumentTracking\MainControl.xaml"
            this.dockSite.PrimaryDocumentChanged += new System.EventHandler<ActiproSoftware.Windows.Controls.Docking.DockingWindowEventArgs>(this.OnDockSitePrimaryDocumentChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.primaryDocumentTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.activeWindowTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
