﻿#pragma checksum "..\..\..\..\..\..\ProductSamples\ViewsSamples\QuickStart\FanPanelIntro\MainControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6D69977706AAE6B339335124086D6E4BDA3F2F30B1703DA2D312B68537458385"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ActiproSoftware.Products.Grids;
using ActiproSoftware.Products.Views;
using ActiproSoftware.SampleBrowser;
using ActiproSoftware.Windows.Controls.Editors.Interop.Grids.PropertyEditors;
using ActiproSoftware.Windows.Controls.Grids;
using ActiproSoftware.Windows.Controls.Grids.PropertyData;
using ActiproSoftware.Windows.Controls.Grids.PropertyEditors;
using ActiproSoftware.Windows.Controls.Views;
using ActiproSoftware.Windows.Controls.Views.Primitives;
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


namespace ActiproSoftware.ProductSamples.ViewsSamples.QuickStart.FanPanelIntro {
    
    
    /// <summary>
    /// MainControl
    /// </summary>
    public partial class MainControl : ActiproSoftware.SampleBrowser.ProductItemControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 2 "..\..\..\..\..\..\ProductSamples\ViewsSamples\QuickStart\FanPanelIntro\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ActiproSoftware.ProductSamples.ViewsSamples.QuickStart.FanPanelIntro.MainControl rootSampleControl;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\..\..\ProductSamples\ViewsSamples\QuickStart\FanPanelIntro\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBox;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp3;component/productsamples/viewssamples/quickstart/fanpanelintro/maincontr" +
                    "ol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\ProductSamples\ViewsSamples\QuickStart\FanPanelIntro\MainControl.xaml"
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
            this.rootSampleControl = ((ActiproSoftware.ProductSamples.ViewsSamples.QuickStart.FanPanelIntro.MainControl)(target));
            return;
            case 2:
            
            #line 17 "..\..\..\..\..\..\ProductSamples\ViewsSamples\QuickStart\FanPanelIntro\MainControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnLayoutDefaultButtonClick);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 18 "..\..\..\..\..\..\ProductSamples\ViewsSamples\QuickStart\FanPanelIntro\MainControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnLayoutTwistButtonClick);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 19 "..\..\..\..\..\..\ProductSamples\ViewsSamples\QuickStart\FanPanelIntro\MainControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnLayoutHorizontalButtonClick);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 20 "..\..\..\..\..\..\ProductSamples\ViewsSamples\QuickStart\FanPanelIntro\MainControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnLayoutVerticalButtonClick);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 43 "..\..\..\..\..\..\ProductSamples\ViewsSamples\QuickStart\FanPanelIntro\MainControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnAddItemClick);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 44 "..\..\..\..\..\..\ProductSamples\ViewsSamples\QuickStart\FanPanelIntro\MainControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnInsertItemClick);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 45 "..\..\..\..\..\..\ProductSamples\ViewsSamples\QuickStart\FanPanelIntro\MainControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnClearAllClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.listBox = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

