#pragma checksum "..\..\..\..\..\..\ProductSamples\SyntaxEditorSamples\Demo\WebAddonJavaScriptEditor\MainControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "92BB1CC6C1478447E86DFAF2FFD5C59EF6BB65C2A7549C628F814BB03E1CFAFE"
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
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.SampleBrowser;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Implementation;
using ActiproSoftware.Text.Languages.CSharp.Implementation;
using ActiproSoftware.Text.Languages.JavaScript.Implementation;
using ActiproSoftware.Text.Languages.Python.Implementation;
using ActiproSoftware.Text.Languages.VB.Implementation;
using ActiproSoftware.Text.Languages.Xml.Implementation;
using ActiproSoftware.Windows;
using ActiproSoftware.Windows.Controls;
using ActiproSoftware.Windows.Controls.ColorSelection;
using ActiproSoftware.Windows.Controls.Docking;
using ActiproSoftware.Windows.Controls.Docking.Primitives;
using ActiproSoftware.Windows.Controls.Primitives;
using ActiproSoftware.Windows.Controls.Rendering;
using ActiproSoftware.Windows.Controls.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Dialogs;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;
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


namespace ActiproSoftware.ProductSamples.SyntaxEditorSamples.Demo.WebAddonJavaScriptEditor {
    
    
    /// <summary>
    /// MainControl
    /// </summary>
    public partial class MainControl : ActiproSoftware.SampleBrowser.ProductItemControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 62 "..\..\..\..\..\..\ProductSamples\SyntaxEditorSamples\Demo\WebAddonJavaScriptEditor\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.StatusBarItem messagePanel;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\..\..\ProductSamples\SyntaxEditorSamples\Demo\WebAddonJavaScriptEditor\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock linePanel;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\..\..\ProductSamples\SyntaxEditorSamples\Demo\WebAddonJavaScriptEditor\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock columnPanel;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\..\..\ProductSamples\SyntaxEditorSamples\Demo\WebAddonJavaScriptEditor\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock characterPanel;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\..\..\ProductSamples\SyntaxEditorSamples\Demo\WebAddonJavaScriptEditor\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ActiproSoftware.Windows.Controls.SyntaxEditor.SyntaxEditor codeEditor;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\..\..\..\..\ProductSamples\SyntaxEditorSamples\Demo\WebAddonJavaScriptEditor\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView errorListView;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\..\..\..\..\ProductSamples\SyntaxEditorSamples\Demo\WebAddonJavaScriptEditor\MainControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ActiproSoftware.Windows.Controls.SyntaxEditor.SyntaxEditor astOutputEditor;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp3;component/productsamples/syntaxeditorsamples/demo/webaddonjavascriptedit" +
                    "or/maincontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\ProductSamples\SyntaxEditorSamples\Demo\WebAddonJavaScriptEditor\MainControl.xaml"
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
            
            #line 18 "..\..\..\..\..\..\ProductSamples\SyntaxEditorSamples\Demo\WebAddonJavaScriptEditor\MainControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnNewFileButtonClick);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 24 "..\..\..\..\..\..\ProductSamples\SyntaxEditorSamples\Demo\WebAddonJavaScriptEditor\MainControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnOpenFileButtonClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.messagePanel = ((System.Windows.Controls.Primitives.StatusBarItem)(target));
            return;
            case 4:
            this.linePanel = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.columnPanel = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.characterPanel = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.codeEditor = ((ActiproSoftware.Windows.Controls.SyntaxEditor.SyntaxEditor)(target));
            
            #line 84 "..\..\..\..\..\..\ProductSamples\SyntaxEditorSamples\Demo\WebAddonJavaScriptEditor\MainControl.xaml"
            this.codeEditor.DocumentParseDataChanged += new System.Windows.RoutedEventHandler(this.OnCodeEditorDocumentParseDataChanged);
            
            #line default
            #line hidden
            
            #line 85 "..\..\..\..\..\..\ProductSamples\SyntaxEditorSamples\Demo\WebAddonJavaScriptEditor\MainControl.xaml"
            this.codeEditor.UserInterfaceUpdate += new System.Windows.RoutedEventHandler(this.OnCodeEditorUserInterfaceUpdate);
            
            #line default
            #line hidden
            
            #line 86 "..\..\..\..\..\..\ProductSamples\SyntaxEditorSamples\Demo\WebAddonJavaScriptEditor\MainControl.xaml"
            this.codeEditor.ViewSelectionChanged += new System.EventHandler<ActiproSoftware.Windows.Controls.SyntaxEditor.EditorViewSelectionEventArgs>(this.OnCodeEditorViewSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.errorListView = ((System.Windows.Controls.ListView)(target));
            
            #line 132 "..\..\..\..\..\..\ProductSamples\SyntaxEditorSamples\Demo\WebAddonJavaScriptEditor\MainControl.xaml"
            this.errorListView.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.OnErrorListViewDoubleClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.astOutputEditor = ((ActiproSoftware.Windows.Controls.SyntaxEditor.SyntaxEditor)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

