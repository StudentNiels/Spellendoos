﻿#pragma checksum "..\..\GameSelector.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0972DE25397F723C1EF63344E061BD304F7ABE293424CC3390F72E1E8E5CB97F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Spellendoos;
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


namespace Spellendoos {
    
    
    /// <summary>
    /// GameSelector
    /// </summary>
    public partial class GameSelector : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\GameSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button options_Btn;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\GameSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button quit_Btn;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\GameSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button start_Yahtzee;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\GameSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button score_Btn;
        
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
            System.Uri resourceLocater = new System.Uri("/Spellendoos;component/gameselector.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\GameSelector.xaml"
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
            this.options_Btn = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\GameSelector.xaml"
            this.options_Btn.Click += new System.Windows.RoutedEventHandler(this.options_Btn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.quit_Btn = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\GameSelector.xaml"
            this.quit_Btn.Click += new System.Windows.RoutedEventHandler(this.quit_Btn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.start_Yahtzee = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\GameSelector.xaml"
            this.start_Yahtzee.Click += new System.Windows.RoutedEventHandler(this.start_Yahtzee_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.score_Btn = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\GameSelector.xaml"
            this.score_Btn.Click += new System.Windows.RoutedEventHandler(this.score_Btn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

