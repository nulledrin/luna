﻿#pragma checksum "..\..\..\..\..\..\ProductSamples\GridsSamples\QuickStart\PropertyGridFiltersBuiltin\MainControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7E0F0138E8E9AA72FD93F08EB16638DFF991A5EDFE82135AFA391860C9DD296E"
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
using ActiproSoftware.Products.Grids;
using ActiproSoftware.Products.Shared;
using ActiproSoftware.SampleBrowser;
using ActiproSoftware.Windows;
using ActiproSoftware.Windows.Controls;
using ActiproSoftware.Windows.Controls.ColorSelection;
using ActiproSoftware.Windows.Controls.Editors;
using ActiproSoftware.Windows.Controls.Editors.Primitives;
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


namespace ActiproSoftware.ProductSamples.GridsSamples.QuickStart.PropertyGridFiltersBuiltin {
    
    
    /// <summary>
    /// MainControl
    /// </summary>
    public partial class MainControl : ActiproSoftware.SampleBrowser.ProductItemControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 74 "..\..\..\..\..\..\ProductSamples\GridsSamples\QuickStart\PropertyGridFiltersBuiltin\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ActiproSoftware.Windows.Controls.Grids.PropertyGrid propGrid;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\..\..\ProductSamples\GridsSamples\QuickStart\PropertyGridFiltersBuiltin\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ActiproSoftware.Windows.Data.Filtering.DataFilterGroup filterGroup;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\..\..\ProductSamples\GridsSamples\QuickStart\PropertyGridFiltersBuiltin\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ActiproSoftware.Windows.Controls.Grids.PropertyData.PropertyModelStringFilter stringFilter;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\..\..\..\ProductSamples\GridsSamples\QuickStart\PropertyGridFiltersBuiltin\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ActiproSoftware.Windows.Controls.Grids.PropertyData.PropertyModelBooleanFilter booleanFilter;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp3;component/productsamples/gridssamples/quickstart/propertygridfiltersbuil" +
                    "tin/maincontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\ProductSamples\GridsSamples\QuickStart\PropertyGridFiltersBuiltin\MainControl.xaml"
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
            this.propGrid = ((ActiproSoftware.Windows.Controls.Grids.PropertyGrid)(target));
            return;
            case 2:
            this.filterGroup = ((ActiproSoftware.Windows.Data.Filtering.DataFilterGroup)(target));
            return;
            case 3:
            this.stringFilter = ((ActiproSoftware.Windows.Controls.Grids.PropertyData.PropertyModelStringFilter)(target));
            return;
            case 4:
            this.booleanFilter = ((ActiproSoftware.Windows.Controls.Grids.PropertyData.PropertyModelBooleanFilter)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

