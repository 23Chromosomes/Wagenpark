#pragma checksum "..\..\WerkplaatsToevoegen.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "839A1FE645D287491ADC78FE30C735C4C8B06A3715CED6E62047E2E85063E5AD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ROCit_P31;
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


namespace ROCit_P31 {
    
    
    /// <summary>
    /// WerkplaatsToevoegen
    /// </summary>
    public partial class WerkplaatsToevoegen : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\WerkplaatsToevoegen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxBedrijfsnaam;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\WerkplaatsToevoegen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxWerkplaatsnaam;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\WerkplaatsToevoegen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnWerkplaatsToevoegen;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\WerkplaatsToevoegen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgWerkplaatsen;
        
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
            System.Uri resourceLocater = new System.Uri("/ROCit_P31;component/werkplaatstoevoegen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WerkplaatsToevoegen.xaml"
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
            this.tbxBedrijfsnaam = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tbxWerkplaatsnaam = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.btnWerkplaatsToevoegen = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\WerkplaatsToevoegen.xaml"
            this.btnWerkplaatsToevoegen.Click += new System.Windows.RoutedEventHandler(this.BtnWerkplaatsToevoegen_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.dgWerkplaatsen = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

