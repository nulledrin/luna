#pragma checksum "..\..\..\..\..\..\ProductSamples\DockingSamples\QuickStart\WindowControlIntro\MainControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "131CA2AFC0776EFD8788D83132F032FA56961DB9F51959EDB10129A2BB9655A6"
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
using ActiproSoftware.Products.Grids;
using ActiproSoftware.Products.Shared;
using ActiproSoftware.SampleBrowser;
using ActiproSoftware.Windows;
using ActiproSoftware.Windows.Controls;
using ActiproSoftware.Windows.Controls.ColorSelection;
using ActiproSoftware.Windows.Controls.Docking;
using ActiproSoftware.Windows.Controls.Docking.Primitives;
using ActiproSoftware.Windows.Controls.Editors.Interop.Grids.PropertyEditors;
using ActiproSoftware.Windows.Controls.Grids;
using ActiproSoftware.Windows.Controls.Grids.PropertyData;
using ActiproSoftware.Windows.Controls.Grids.PropertyEditors;
using ActiproSoftware.Windows.Controls.Primitives;
using ActiproSoftware.Windows.Controls.Rendering;
using ActiproSoftware.Windows.Data;
using ActiproSoftware.Windows.Data.Filtering;
using ActiproSoftware.Windows.DocumentManagement;
using ActiproSoftware.Windows.Input;
using ActiproSoftware.Windows.Media;
using ActiproSoftware.Windows.Media.Animation;
using ActiproSoftware.Windows.Shapes;
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


namespace ActiproSoftware.ProductSamples.DockingSamples.QuickStart.WindowControlIntro {
    
    
    /// <summary>
    /// MainControl
    /// </summary>
    public partial class MainControl : ActiproSoftware.SampleBrowser.ProductItemControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 76 "..\..\..\..\..\..\ProductSamples\DockingSamples\QuickStart\WindowControlIntro\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ActiproSoftware.Windows.Controls.Docking.DockSite dockSite;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\..\..\..\ProductSamples\DockingSamples\QuickStart\WindowControlIntro\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ActiproSoftware.Windows.Controls.Docking.WindowControl window;
        
        #line default
        #line hidden
        
        
        #line 148 "..\..\..\..\..\..\ProductSamples\DockingSamples\QuickStart\WindowControlIntro\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ActiproSoftware.Windows.Controls.Docking.ToolWindow outputToolWindow;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\..\..\..\..\ProductSamples\DockingSamples\QuickStart\WindowControlIntro\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox eventsListBox;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp3;component/productsamples/dockingsamples/quickstart/windowcontrolintro/ma" +
                    "incontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\ProductSamples\DockingSamples\QuickStart\WindowControlIntro\MainControl.xaml"
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
            case 2:
            this.dockSite = ((ActiproSoftware.Windows.Controls.Docking.DockSite)(target));
            
            #line 77 "..\..\..\..\..\..\ProductSamples\DockingSamples\QuickStart\WindowControlIntro\MainControl.xaml"
            this.dockSite.MenuOpening += new System.EventHandler<ActiproSoftware.Windows.Controls.Docking.DockingMenuEventArgs>(this.OnDockSiteMenuOpening);
            
            #line default
            #line hidden
            return;
            case 3:
            this.window = ((ActiproSoftware.Windows.Controls.Docking.WindowControl)(target));
            
            #line 96 "..\..\..\..\..\..\ProductSamples\DockingSamples\QuickStart\WindowControlIntro\MainControl.xaml"
            this.window.Activated += new System.Windows.RoutedEventHandler(this.OnWindowActivated);
            
            #line default
            #line hidden
            
            #line 97 "..\..\..\..\..\..\ProductSamples\DockingSamples\QuickStart\WindowControlIntro\MainControl.xaml"
            this.window.Closed += new System.Windows.RoutedEventHandler(this.OnWindowClosed);
            
            #line default
            #line hidden
            
            #line 98 "..\..\..\..\..\..\ProductSamples\DockingSamples\QuickStart\WindowControlIntro\MainControl.xaml"
            this.window.Closing += new System.EventHandler<ActiproSoftware.Windows.CancelRoutedEventArgs>(this.OnWindowClosing);
            
            #line default
            #line hidden
            
            #line 99 "..\..\..\..\..\..\ProductSamples\DockingSamples\QuickStart\WindowControlIntro\MainControl.xaml"
            this.window.Deactivated += new System.Windows.RoutedEventHandler(this.OnWindowDeactivated);
            
            #line default
            #line hidden
            
            #line 100 "..\..\..\..\..\..\ProductSamples\DockingSamples\QuickStart\WindowControlIntro\MainControl.xaml"
            this.window.DragMoved += new System.Windows.RoutedEventHandler(this.OnWindowDragMoved);
            
            #line default
            #line hidden
            
            #line 101 "..\..\..\..\..\..\ProductSamples\DockingSamples\QuickStart\WindowControlIntro\MainControl.xaml"
            this.window.DragMoving += new System.EventHandler<ActiproSoftware.Windows.CancelRoutedEventArgs>(this.OnWindowDragMoving);
            
            #line default
            #line hidden
            
            #line 102 "..\..\..\..\..\..\ProductSamples\DockingSamples\QuickStart\WindowControlIntro\MainControl.xaml"
            this.window.LocationChanged += new System.Windows.RoutedEventHandler(this.OnWindowLocationChanged);
            
            #line default
            #line hidden
            
            #line 103 "..\..\..\..\..\..\ProductSamples\DockingSamples\QuickStart\WindowControlIntro\MainControl.xaml"
            this.window.Opened += new System.Windows.RoutedEventHandler(this.OnWindowOpened);
            
            #line default
            #line hidden
            
            #line 104 "..\..\..\..\..\..\ProductSamples\DockingSamples\QuickStart\WindowControlIntro\MainControl.xaml"
            this.window.SizeChanged += new System.Windows.SizeChangedEventHandler(this.OnWindowSizeChanged);
            
            #line default
            #line hidden
            
            #line 105 "..\..\..\..\..\..\ProductSamples\DockingSamples\QuickStart\WindowControlIntro\MainControl.xaml"
            this.window.StateChanged += new System.Windows.RoutedEventHandler(this.OnWindowStateChanged);
            
            #line default
            #line hidden
            
            #line 106 "..\..\..\..\..\..\ProductSamples\DockingSamples\QuickStart\WindowControlIntro\MainControl.xaml"
            this.window.TitleBarDoubleTapped += new System.EventHandler<ActiproSoftware.Windows.CancelRoutedEventArgs>(this.OnWindowTitleBarDoubleTapped);
            
            #line default
            #line hidden
            
            #line 107 "..\..\..\..\..\..\ProductSamples\DockingSamples\QuickStart\WindowControlIntro\MainControl.xaml"
            this.window.TitleBarMenuOpening += new System.EventHandler<ActiproSoftware.Windows.Controls.Docking.DockingMenuEventArgs>(this.OnWindowTitleBarMenuOpening);
            
            #line default
            #line hidden
            return;
            case 4:
            this.outputToolWindow = ((ActiproSoftware.Windows.Controls.Docking.ToolWindow)(target));
            return;
            case 5:
            this.eventsListBox = ((System.Windows.Controls.ListBox)(target));
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
            case 1:
            
            #line 54 "..\..\..\..\..\..\ProductSamples\DockingSamples\QuickStart\WindowControlIntro\MainControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnOpenWindowButtonClick);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

