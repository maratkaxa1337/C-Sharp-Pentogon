// Updated by XamlIntelliSenseFileGenerator 01.10.2020 23:02:11
#pragma checksum "..\..\..\..\..\Views\Pages\ViewDataPages\UserViewData.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "21DC68B5DD0AE0182E8FFD809C3A6EB8E87E6D92608C859775E1FB0E26515E45"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using My_City_Car_Driver.Views.Pages.ViewDataPages;
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


namespace My_City_Car_Driver.Views.Pages.ViewDataPages
{


    /// <summary>
    /// UserViewData
    /// </summary>
    public partial class UserViewData : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector
    {


#line 21 "..\..\..\..\..\Views\Pages\ViewDataPages\UserViewData.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonBack;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/My_City_Car_Driver;component/views/pages/viewdatapages/userviewdata.xaml", System.UriKind.Relative);

#line 1 "..\..\..\..\..\Views\Pages\ViewDataPages\UserViewData.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.buttonBack = ((System.Windows.Controls.Button)(target));

#line 25 "..\..\..\..\..\Views\Pages\ViewDataPages\UserViewData.xaml"
                    this.buttonBack.Click += new System.Windows.RoutedEventHandler(this.buttonBack_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.DataGrid dataView;
        internal System.Windows.Controls.Button buttonSave;
        internal System.Windows.Controls.Button buttonRemove;
    }
}

