#pragma checksum "..\..\..\..\..\..\ProductSamples\ViewsSamples\QuickStart\Common\ProductListBoxItem.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A5A1895AC227FAECE249D667A3CEE47A49C20F252C2C5149B4E100C2646BC7A9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ActiproSoftware.ProductSamples.ViewsSamples.QuickStart.Common;
using ActiproSoftware.Products.Shared;
using ActiproSoftware.Products.Views;
using ActiproSoftware.Windows;
using ActiproSoftware.Windows.Controls;
using ActiproSoftware.Windows.Controls.ColorSelection;
using ActiproSoftware.Windows.Controls.Primitives;
using ActiproSoftware.Windows.Controls.Rendering;
using ActiproSoftware.Windows.Controls.Views;
using ActiproSoftware.Windows.Controls.Views.Primitives;
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


namespace ActiproSoftware.ProductSamples.ViewsSamples.QuickStart.Common {
    
    
    /// <summary>
    /// ProductListBoxItem
    /// </summary>
    public partial class ProductListBoxItem : System.Windows.Controls.ListBoxItem, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp3;component/productsamples/viewssamples/quickstart/common/productlistboxit" +
                    "em.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\ProductSamples\ViewsSamples\QuickStart\Common\ProductListBoxItem.xaml"
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
            
            #line 34 "..\..\..\..\..\..\ProductSamples\ViewsSamples\QuickStart\Common\ProductListBoxItem.xaml"
            ((ActiproSoftware.Windows.Controls.PopupButton)(target)).Click += new System.Windows.RoutedEventHandler(this.OnDeleteButtonClick);
            
            #line default
            #line hidden
            break;
            case 2:
            
            #line 51 "..\..\..\..\..\..\ProductSamples\ViewsSamples\QuickStart\Common\ProductListBoxItem.xaml"
            ((ActiproSoftware.Windows.Controls.PopupButton)(target)).Click += new System.Windows.RoutedEventHandler(this.OnDockLeftButtonClick);
            
            #line default
            #line hidden
            break;
            case 3:
            
            #line 58 "..\..\..\..\..\..\ProductSamples\ViewsSamples\QuickStart\Common\ProductListBoxItem.xaml"
            ((ActiproSoftware.Windows.Controls.PopupButton)(target)).Click += new System.Windows.RoutedEventHandler(this.OnDockRightButtonClick);
            
            #line default
            #line hidden
            break;
            case 4:
            
            #line 65 "..\..\..\..\..\..\ProductSamples\ViewsSamples\QuickStart\Common\ProductListBoxItem.xaml"
            ((ActiproSoftware.Windows.Controls.PopupButton)(target)).Click += new System.Windows.RoutedEventHandler(this.OnDockTopButtonClick);
            
            #line default
            #line hidden
            break;
            case 5:
            
            #line 72 "..\..\..\..\..\..\ProductSamples\ViewsSamples\QuickStart\Common\ProductListBoxItem.xaml"
            ((ActiproSoftware.Windows.Controls.PopupButton)(target)).Click += new System.Windows.RoutedEventHandler(this.OnDockBottomButtonClick);
            
            #line default
            #line hidden
            break;
            case 6:
            
            #line 79 "..\..\..\..\..\..\ProductSamples\ViewsSamples\QuickStart\Common\ProductListBoxItem.xaml"
            ((ActiproSoftware.Windows.Controls.PopupButton)(target)).Click += new System.Windows.RoutedEventHandler(this.OnMoveLeftButtonClick);
            
            #line default
            #line hidden
            break;
            case 7:
            
            #line 86 "..\..\..\..\..\..\ProductSamples\ViewsSamples\QuickStart\Common\ProductListBoxItem.xaml"
            ((ActiproSoftware.Windows.Controls.PopupButton)(target)).Click += new System.Windows.RoutedEventHandler(this.OnMoveRightButtonClick);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

