#pragma checksum "..\..\..\..\..\..\ProductSamples\ThemesSamples\QuickStart\WindowChromeSystemMenuCustomization\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B589576C40BD3FF8C05B2066F792EC59CA7BEC5E15842D2C1CB8AA4D512B2F36"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ActiproSoftware.SampleBrowser;
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


namespace ActiproSoftware.ProductSamples.ThemesSamples.QuickStart.WindowChromeSystemMenuCustomization {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\..\..\..\ProductSamples\ThemesSamples\QuickStart\WindowChromeSystemMenuCustomization\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ActiproSoftware.ProductSamples.ThemesSamples.QuickStart.WindowChromeSystemMenuCustomization.MainWindow window;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\..\..\ProductSamples\ThemesSamples\QuickStart\WindowChromeSystemMenuCustomization\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ActiproSoftware.Windows.Themes.WindowChrome chrome;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\..\..\ProductSamples\ThemesSamples\QuickStart\WindowChromeSystemMenuCustomization\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox useCustomSystemMenuCheckBox;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\..\..\ProductSamples\ThemesSamples\QuickStart\WindowChromeSystemMenuCustomization\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ActiproSoftware.SampleBrowser.RichTextBox editor;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp3;component/productsamples/themessamples/quickstart/windowchromesystemmenu" +
                    "customization/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\ProductSamples\ThemesSamples\QuickStart\WindowChromeSystemMenuCustomization\MainWindow.xaml"
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
            this.window = ((ActiproSoftware.ProductSamples.ThemesSamples.QuickStart.WindowChromeSystemMenuCustomization.MainWindow)(target));
            return;
            case 2:
            
            #line 13 "..\..\..\..\..\..\ProductSamples\ThemesSamples\QuickStart\WindowChromeSystemMenuCustomization\MainWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.OnHelpCommandExecuted);
            
            #line default
            #line hidden
            return;
            case 3:
            this.chrome = ((ActiproSoftware.Windows.Themes.WindowChrome)(target));
            
            #line 17 "..\..\..\..\..\..\ProductSamples\ThemesSamples\QuickStart\WindowChromeSystemMenuCustomization\MainWindow.xaml"
            this.chrome.WindowSystemMenuOpening += new System.EventHandler<ActiproSoftware.Windows.Controls.ContextMenuOpeningEventArgs>(this.OnWindowSystemMenuOpening);
            
            #line default
            #line hidden
            return;
            case 4:
            this.useCustomSystemMenuCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 5:
            this.editor = ((ActiproSoftware.SampleBrowser.RichTextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

