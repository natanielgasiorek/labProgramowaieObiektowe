﻿#pragma checksum "..\..\..\Widoki\Edytowanie_producenta.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "89C3D5BCE4DB9D2D217E5350E47B16408927F2E80003F073B679874C18BBC415"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using DevExpress.Core;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Core.ConditionalFormatting;
using DevExpress.Xpf.Core.DataSources;
using DevExpress.Xpf.Core.Serialization;
using DevExpress.Xpf.Core.ServerMode;
using DevExpress.Xpf.DXBinding;
using DevExpress.Xpf.Data;
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


namespace Sklep_Zoologiczny.Widoki {
    
    
    /// <summary>
    /// Edytowanie_producenta
    /// </summary>
    public partial class Edytowanie_producenta : DevExpress.Xpf.Core.ThemedWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Widoki\Edytowanie_producenta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Core.SimpleButton Zapisz_edytowanie_nazwy_producenta;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Widoki\Edytowanie_producenta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBox_wybierz_producenta;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Widoki\Edytowanie_producenta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Wpisz_nowa_nazwe_producenta;
        
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
            System.Uri resourceLocater = new System.Uri("/Sklep Zoologiczny;component/widoki/edytowanie_producenta.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Widoki\Edytowanie_producenta.xaml"
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
            this.Zapisz_edytowanie_nazwy_producenta = ((DevExpress.Xpf.Core.SimpleButton)(target));
            
            #line 10 "..\..\..\Widoki\Edytowanie_producenta.xaml"
            this.Zapisz_edytowanie_nazwy_producenta.Click += new System.Windows.RoutedEventHandler(this.Zapisz_edytowanie_nazwy_producenta_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ComboBox_wybierz_producenta = ((System.Windows.Controls.ComboBox)(target));
            
            #line 11 "..\..\..\Widoki\Edytowanie_producenta.xaml"
            this.ComboBox_wybierz_producenta.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_wybierz_producenta_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Wpisz_nowa_nazwe_producenta = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
