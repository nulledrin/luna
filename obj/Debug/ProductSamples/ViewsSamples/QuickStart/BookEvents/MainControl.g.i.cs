#pragma checksum "..\..\..\..\..\..\ProductSamples\ViewsSamples\QuickStart\BookEvents\MainControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8E039EEDA0139652B9AFE9174732B00D0C7B40600CB8B503341758BB8777F1DF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ActiproSoftware.ProductSamples.ViewsSamples.QuickStart.BookEvents;
using ActiproSoftware.Products.Views;
using ActiproSoftware.SampleBrowser;
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


namespace ActiproSoftware.ProductSamples.ViewsSamples.QuickStart.BookEvents {
    
    
    /// <summary>
    /// MainControl
    /// </summary>
    public partial class MainControl : ActiproSoftware.SampleBrowser.ProductItemControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 85 "..\..\..\..\..\..\ProductSamples\ViewsSamples\QuickStart\BookEvents\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox eventsListBox;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\..\..\..\ProductSamples\ViewsSamples\QuickStart\BookEvents\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock curlInstructions;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\..\..\..\ProductSamples\ViewsSamples\QuickStart\BookEvents\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock flipInstructions;
        
        #line default
        #line hidden
        
        
        #line 148 "..\..\..\..\..\..\ProductSamples\ViewsSamples\QuickStart\BookEvents\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cancelPageCurlActivatingCheckBox;
        
        #line default
        #line hidden
        
        
        #line 179 "..\..\..\..\..\..\ProductSamples\ViewsSamples\QuickStart\BookEvents\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cancelPageFlippingCheckBox;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp3;component/productsamples/viewssamples/quickstart/bookevents/maincontrol." +
                    "xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\ProductSamples\ViewsSamples\QuickStart\BookEvents\MainControl.xaml"
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
            this.eventsListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 2:
            
            #line 86 "..\..\..\..\..\..\ProductSamples\ViewsSamples\QuickStart\BookEvents\MainControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnClearListClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.curlInstructions = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.flipInstructions = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            
            #line 114 "..\..\..\..\..\..\ProductSamples\ViewsSamples\QuickStart\BookEvents\MainControl.xaml"
            ((ActiproSoftware.Windows.Controls.Views.Book)(target)).PageCurlActivated += new System.EventHandler<ActiproSoftware.Windows.Controls.Views.BookPageRoutedEventArgs>(this.OnPageCurlActivated);
            
            #line default
            #line hidden
            
            #line 115 "..\..\..\..\..\..\ProductSamples\ViewsSamples\QuickStart\BookEvents\MainControl.xaml"
            ((ActiproSoftware.Windows.Controls.Views.Book)(target)).PageCurlActivating += new System.EventHandler<ActiproSoftware.Windows.Controls.Views.CancelBookPageRoutedEventArgs>(this.OnPageCurlActivating);
            
            #line default
            #line hidden
            
            #line 115 "..\..\..\..\..\..\ProductSamples\ViewsSamples\QuickStart\BookEvents\MainControl.xaml"
            ((ActiproSoftware.Windows.Controls.Views.Book)(target)).PageCurlDeactivated += new System.EventHandler<ActiproSoftware.Windows.Controls.Views.BookPageRoutedEventArgs>(this.OnPageCurlDeactivated);
            
            #line default
            #line hidden
            
            #line 116 "..\..\..\..\..\..\ProductSamples\ViewsSamples\QuickStart\BookEvents\MainControl.xaml"
            ((ActiproSoftware.Windows.Controls.Views.Book)(target)).PageFlipped += new System.EventHandler<ActiproSoftware.Windows.Controls.Views.BookPageRoutedEventArgs>(this.OnPageFlipped);
            
            #line default
            #line hidden
            
            #line 116 "..\..\..\..\..\..\ProductSamples\ViewsSamples\QuickStart\BookEvents\MainControl.xaml"
            ((ActiproSoftware.Windows.Controls.Views.Book)(target)).PageFlipping += new System.EventHandler<ActiproSoftware.Windows.Controls.Views.CancelBookPageRoutedEventArgs>(this.OnPageFlipping);
            
            #line default
            #line hidden
            
            #line 116 "..\..\..\..\..\..\ProductSamples\ViewsSamples\QuickStart\BookEvents\MainControl.xaml"
            ((ActiproSoftware.Windows.Controls.Views.Book)(target)).SelectedViewChanged += new System.EventHandler<ActiproSoftware.Windows.PropertyChangedRoutedEventArgs<int>>(this.OnSelectedViewChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cancelPageCurlActivatingCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 7:
            this.cancelPageFlippingCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

