﻿

#pragma checksum "C:\Projects\TouchPointWindows\TouchPointWindows\Views\MenuView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F4717FF801437F5491EB6676C0E75FF2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TouchPointWindows.Views
{
    partial class MenuView : global::TouchPointWindows.Common.PageBase
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::TouchPointWindows.Common.PageBase menuPage; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button backButton; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Telerik.UI.Xaml.Controls.Grid.RadDataGrid radGrid; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private bool _contentLoaded;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            global::Windows.UI.Xaml.Application.LoadComponent(this, new global::System.Uri("ms-appx:///Views/MenuView.xaml"), global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            menuPage = (global::TouchPointWindows.Common.PageBase)this.FindName("menuPage");
            backButton = (global::Windows.UI.Xaml.Controls.Button)this.FindName("backButton");
            radGrid = (global::Telerik.UI.Xaml.Controls.Grid.RadDataGrid)this.FindName("radGrid");
        }
    }
}


