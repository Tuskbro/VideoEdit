﻿#pragma checksum "..\..\..\Player.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "662B47479CB7BF9BADB5ED83E25EBFFA513188EF6A51CD87C4FC564FD0D1F4B7"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using Preview;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace Preview {
    
    
    /// <summary>
    /// Player
    /// </summary>
    public partial class Player : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\Player.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement View;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Player.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RecognitionText;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Player.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OpenFile;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Player.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackPriviewBtn;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Player.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StopPriViewBtn;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Player.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PlayPriviewBtn;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Player.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PausePriviewBtn;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Player.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NextPriviewBtn;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Player.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MutePriviewBtn;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Player.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton SubON;
        
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
            System.Uri resourceLocater = new System.Uri("/Preview;component/player.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Player.xaml"
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
            
            #line 9 "..\..\..\Player.xaml"
            ((Preview.Player)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.View = ((System.Windows.Controls.MediaElement)(target));
            return;
            case 3:
            this.RecognitionText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.OpenFile = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\Player.xaml"
            this.OpenFile.Click += new System.Windows.RoutedEventHandler(this.OpenFile_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BackPriviewBtn = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Player.xaml"
            this.BackPriviewBtn.Click += new System.Windows.RoutedEventHandler(this.BackPriviewBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.StopPriViewBtn = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Player.xaml"
            this.StopPriViewBtn.Click += new System.Windows.RoutedEventHandler(this.StopPriViewBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.PlayPriviewBtn = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Player.xaml"
            this.PlayPriviewBtn.Click += new System.Windows.RoutedEventHandler(this.PlayPriviewBtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.PausePriviewBtn = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Player.xaml"
            this.PausePriviewBtn.Click += new System.Windows.RoutedEventHandler(this.PausePriviewBtn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.NextPriviewBtn = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\Player.xaml"
            this.NextPriviewBtn.Click += new System.Windows.RoutedEventHandler(this.NextPriviewBtn_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.MutePriviewBtn = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\Player.xaml"
            this.MutePriviewBtn.Click += new System.Windows.RoutedEventHandler(this.MutePriviewBtn_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.SubON = ((System.Windows.Controls.RadioButton)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

