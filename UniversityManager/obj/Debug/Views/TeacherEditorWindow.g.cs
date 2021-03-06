﻿#pragma checksum "..\..\..\Views\TeacherEditorWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "34626E47EA813D350FAFE0F9E092CAB2415EAAE9B029564368378A0D858F194A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using UniversityManager.Views;


namespace UniversityManager.Views {
    
    
    /// <summary>
    /// TeacherEditorWindow
    /// </summary>
    public partial class TeacherEditorWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Views\TeacherEditorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button changePhotoButton;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Views\TeacherEditorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Views\TeacherEditorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameBlock;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Views\TeacherEditorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox surnameBlock;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Views\TeacherEditorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker startYearPicker;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Views\TeacherEditorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button rejectButton;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Views\TeacherEditorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteButton;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Views\TeacherEditorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button acceptButton;
        
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
            System.Uri resourceLocater = new System.Uri("/UniversityManager;component/views/teachereditorwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\TeacherEditorWindow.xaml"
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
            this.changePhotoButton = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\Views\TeacherEditorWindow.xaml"
            this.changePhotoButton.Click += new System.Windows.RoutedEventHandler(this.changePhotoButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.image = ((System.Windows.Controls.Image)(target));
            
            #line 13 "..\..\..\Views\TeacherEditorWindow.xaml"
            this.image.MouseEnter += new System.Windows.Input.MouseEventHandler(this.image_MouseEnter);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\Views\TeacherEditorWindow.xaml"
            this.image.MouseLeave += new System.Windows.Input.MouseEventHandler(this.image_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 3:
            this.nameBlock = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.surnameBlock = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.startYearPicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.rejectButton = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\Views\TeacherEditorWindow.xaml"
            this.rejectButton.Click += new System.Windows.RoutedEventHandler(this.rejectButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.deleteButton = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Views\TeacherEditorWindow.xaml"
            this.deleteButton.Click += new System.Windows.RoutedEventHandler(this.deleteButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.acceptButton = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Views\TeacherEditorWindow.xaml"
            this.acceptButton.Click += new System.Windows.RoutedEventHandler(this.acceptButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

