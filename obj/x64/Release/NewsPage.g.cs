﻿#pragma checksum "C:\Users\Josh\source\repos\Best Of Beijing\Best Of Beijing\NewsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C92142FBB594C5025E6BBD1DD51D020C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Best_Of_Beijing
{
    partial class NewsPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // NewsPage.xaml line 17
                {
                    global::Windows.UI.Xaml.Controls.Grid element1 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    ((global::Windows.UI.Xaml.Controls.Grid)element1).KeyDown += this.Go_KeyDown;
                }
                break;
            case 2: // NewsPage.xaml line 55
                {
                    this.ArticleWebView = (global::Windows.UI.Xaml.Controls.WebView)(target);
                }
                break;
            case 3: // NewsPage.xaml line 26
                {
                    this.Value = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4: // NewsPage.xaml line 29
                {
                    this.Display = (global::Windows.UI.Xaml.Controls.ItemsControl)(target);
                }
                break;
            case 5: // NewsPage.xaml line 37
                {
                    global::Windows.UI.Xaml.Controls.TextBlock element5 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBlock)element5).Tapped += this.Address_OnTapped;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
