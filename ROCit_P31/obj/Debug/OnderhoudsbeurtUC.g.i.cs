﻿#pragma checksum "..\..\OnderhoudsbeurtUC.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0B7A0667EC476479531A3CA4E5736B51FAAA8AB3813761C2C7AB9D7A410B6C82"
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
    /// OnderhoudsbeurtUC
    /// </summary>
    public partial class OnderhoudsbeurtUC : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 15 "..\..\OnderhoudsbeurtUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxbeurtnaam;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\OnderhoudsbeurtUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxprijs;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\OnderhoudsbeurtUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbxomschrijving;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\OnderhoudsbeurtUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbxauto;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\OnderhoudsbeurtUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOpslaanBeurt;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\OnderhoudsbeurtUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgBeurten;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\OnderhoudsbeurtUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpUitvoerdatum;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\OnderhoudsbeurtUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbxWerkplaats;
        
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
            System.Uri resourceLocater = new System.Uri("/ROCit_P31;component/onderhoudsbeurtuc.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\OnderhoudsbeurtUC.xaml"
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
            this.tbxbeurtnaam = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tbxprijs = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\OnderhoudsbeurtUC.xaml"
            this.tbxprijs.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Tbxprijs_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tbxomschrijving = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.cbxauto = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.btnOpslaanBeurt = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\OnderhoudsbeurtUC.xaml"
            this.btnOpslaanBeurt.Click += new System.Windows.RoutedEventHandler(this.BtnOpslaanBeurt_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.dgBeurten = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 9:
            this.dpUitvoerdatum = ((System.Windows.Controls.DatePicker)(target));
            
            #line 50 "..\..\OnderhoudsbeurtUC.xaml"
            this.dpUitvoerdatum.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.DpUitvoerdatum_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.cbxWerkplaats = ((System.Windows.Controls.ComboBox)(target));
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
            case 7:
            
            #line 32 "..\..\OnderhoudsbeurtUC.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnVerwijderen_Click);
            
            #line default
            #line hidden
            break;
            case 8:
            
            #line 42 "..\..\OnderhoudsbeurtUC.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnWijzigBeurt_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

