#pragma checksum "..\..\..\..\..\..\ProductSamples\GaugeSamples\QuickStart\LinearGaugeRollingScale\MainControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E20460B0474E68C527A711892A41E89582351E496C6330A91EAD8276275B4C96"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ActiproSoftware.ProductSamples.GaugeSamples.QuickStart.LinearGaugeRollingScale;
using ActiproSoftware.Products.Gauge;
using ActiproSoftware.Products.Grids;
using ActiproSoftware.Products.Shared;
using ActiproSoftware.SampleBrowser;
using ActiproSoftware.Windows;
using ActiproSoftware.Windows.Controls;
using ActiproSoftware.Windows.Controls.ColorSelection;
using ActiproSoftware.Windows.Controls.Editors.Interop.Grids.PropertyEditors;
using ActiproSoftware.Windows.Controls.Gauge;
using ActiproSoftware.Windows.Controls.Gauge.Primitives;
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


namespace ActiproSoftware.ProductSamples.GaugeSamples.QuickStart.LinearGaugeRollingScale {
    
    
    /// <summary>
    /// MainControl
    /// </summary>
    public partial class MainControl : ActiproSoftware.SampleBrowser.ProductItemControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 56 "..\..\..\..\..\..\ProductSamples\GaugeSamples\QuickStart\LinearGaugeRollingScale\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ActiproSoftware.Windows.Controls.Gauge.LinearGauge gauge;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\..\..\ProductSamples\GaugeSamples\QuickStart\LinearGaugeRollingScale\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ActiproSoftware.Windows.Controls.Gauge.LinearTickSet tickSet;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\..\..\..\ProductSamples\GaugeSamples\QuickStart\LinearGaugeRollingScale\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ActiproSoftware.Windows.Controls.Gauge.LinearPointerMarker currentValueMarker;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\..\..\..\..\ProductSamples\GaugeSamples\QuickStart\LinearGaugeRollingScale\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ActiproSoftware.Windows.Controls.Gauge.LinearPointerMarker headingMarker;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp3;component/productsamples/gaugesamples/quickstart/lineargaugerollingscale" +
                    "/maincontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\ProductSamples\GaugeSamples\QuickStart\LinearGaugeRollingScale\MainControl.xaml"
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
            this.gauge = ((ActiproSoftware.Windows.Controls.Gauge.LinearGauge)(target));
            return;
            case 2:
            this.tickSet = ((ActiproSoftware.Windows.Controls.Gauge.LinearTickSet)(target));
            return;
            case 3:
            this.currentValueMarker = ((ActiproSoftware.Windows.Controls.Gauge.LinearPointerMarker)(target));
            return;
            case 4:
            this.headingMarker = ((ActiproSoftware.Windows.Controls.Gauge.LinearPointerMarker)(target));
            return;
            case 5:
            
            #line 159 "..\..\..\..\..\..\ProductSamples\GaugeSamples\QuickStart\LinearGaugeRollingScale\MainControl.xaml"
            ((System.Windows.Controls.Primitives.RepeatButton)(target)).Click += new System.Windows.RoutedEventHandler(this.OnDecreaseButtonClick);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 160 "..\..\..\..\..\..\ProductSamples\GaugeSamples\QuickStart\LinearGaugeRollingScale\MainControl.xaml"
            ((System.Windows.Controls.Primitives.RepeatButton)(target)).Click += new System.Windows.RoutedEventHandler(this.OnIncreaseButtonClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

