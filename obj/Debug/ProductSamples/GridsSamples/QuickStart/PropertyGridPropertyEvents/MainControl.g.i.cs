﻿#pragma checksum "..\..\..\..\..\..\ProductSamples\GridsSamples\QuickStart\PropertyGridPropertyEvents\MainControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D4C32FDEA32BBAAB25FDF688DA1FEAD625C542AA8A4F6231E92EEDE840DDD6C2"
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
using ActiproSoftware.SampleBrowser;
using ActiproSoftware.Windows.Controls.Grids;
using ActiproSoftware.Windows.Controls.Grids.PropertyData;
using ActiproSoftware.Windows.Controls.Grids.PropertyEditors;
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


namespace ActiproSoftware.ProductSamples.GridsSamples.QuickStart.PropertyGridPropertyEvents {
    
    
    /// <summary>
    /// MainControl
    /// </summary>
    public partial class MainControl : ActiproSoftware.SampleBrowser.ProductItemControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 2 "..\..\..\..\..\..\ProductSamples\GridsSamples\QuickStart\PropertyGridPropertyEvents\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ActiproSoftware.ProductSamples.GridsSamples.QuickStart.PropertyGridPropertyEvents.MainControl rootSampleControl;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\..\..\ProductSamples\GridsSamples\QuickStart\PropertyGridPropertyEvents\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox eventsListBox;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\..\..\ProductSamples\GridsSamples\QuickStart\PropertyGridPropertyEvents\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ActiproSoftware.Windows.Controls.Grids.PropertyGrid propGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp3;component/productsamples/gridssamples/quickstart/propertygridpropertyeve" +
                    "nts/maincontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\ProductSamples\GridsSamples\QuickStart\PropertyGridPropertyEvents\MainControl.xaml"
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
            this.rootSampleControl = ((ActiproSoftware.ProductSamples.GridsSamples.QuickStart.PropertyGridPropertyEvents.MainControl)(target));
            return;
            case 2:
            this.eventsListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            
            #line 22 "..\..\..\..\..\..\ProductSamples\GridsSamples\QuickStart\PropertyGridPropertyEvents\MainControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnClearButtonClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.propGrid = ((ActiproSoftware.Windows.Controls.Grids.PropertyGrid)(target));
            
            #line 45 "..\..\..\..\..\..\ProductSamples\GridsSamples\QuickStart\PropertyGridPropertyEvents\MainControl.xaml"
            this.propGrid.ChildPropertyAdded += new System.EventHandler<ActiproSoftware.Windows.Controls.Grids.PropertyModelChildChangeEventArgs>(this.OnPropertyGridChildPropertyAdded);
            
            #line default
            #line hidden
            
            #line 46 "..\..\..\..\..\..\ProductSamples\GridsSamples\QuickStart\PropertyGridPropertyEvents\MainControl.xaml"
            this.propGrid.ChildPropertyAdding += new System.EventHandler<ActiproSoftware.Windows.Controls.Grids.PropertyModelChildChangeEventArgs>(this.OnPropertyGridChildPropertyAdding);
            
            #line default
            #line hidden
            
            #line 47 "..\..\..\..\..\..\ProductSamples\GridsSamples\QuickStart\PropertyGridPropertyEvents\MainControl.xaml"
            this.propGrid.ChildPropertyRemoved += new System.EventHandler<ActiproSoftware.Windows.Controls.Grids.PropertyModelChildChangeEventArgs>(this.OnPropertyGridChildPropertyRemoved);
            
            #line default
            #line hidden
            
            #line 48 "..\..\..\..\..\..\ProductSamples\GridsSamples\QuickStart\PropertyGridPropertyEvents\MainControl.xaml"
            this.propGrid.ChildPropertyRemoving += new System.EventHandler<ActiproSoftware.Windows.Controls.Grids.PropertyModelChildChangeEventArgs>(this.OnPropertyGridChildPropertyRemoving);
            
            #line default
            #line hidden
            
            #line 49 "..\..\..\..\..\..\ProductSamples\GridsSamples\QuickStart\PropertyGridPropertyEvents\MainControl.xaml"
            this.propGrid.PropertyValueChanged += new System.EventHandler<ActiproSoftware.Windows.Controls.Grids.PropertyModelValueChangeEventArgs>(this.OnPropertyGridPropertyValueChanged);
            
            #line default
            #line hidden
            
            #line 50 "..\..\..\..\..\..\ProductSamples\GridsSamples\QuickStart\PropertyGridPropertyEvents\MainControl.xaml"
            this.propGrid.PropertyValueChanging += new System.EventHandler<ActiproSoftware.Windows.Controls.Grids.PropertyModelValueChangeEventArgs>(this.OnPropertyGridPropertyValueChanging);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
