﻿#pragma checksum "C:\Users\Josh\source\repos\Best Of Beijing\Best Of Beijing\EatPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "639197CB5B1EE82AAE9D187F097011E9"
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
    partial class EatPage : 
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
            case 1: // EatPage.xaml line 59
                {
                    this.pageGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2: // EatPage.xaml line 74
                {
                    this.MapControl1 = (global::Windows.UI.Xaml.Controls.Maps.MapControl)(target);
                }
                break;
            case 3: // EatPage.xaml line 79
                {
                    this.info = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // EatPage.xaml line 68
                {
                    this.btnBeijing = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnBeijing).Click += this.btnBeijing_Click;
                }
                break;
            case 5: // EatPage.xaml line 69
                {
                    this.btnAerial = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnAerial).Click += this.btnAerial_Click;
                }
                break;
            case 6: // EatPage.xaml line 70
                {
                    this.btnAerialRoad = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnAerialRoad).Click += this.btnAerialRoad_Click;
                }
                break;
            case 7: // EatPage.xaml line 71
                {
                    this.btnDefault = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnDefault).Click += this.btnDefault_Click;
                }
                break;
            case 8: // EatPage.xaml line 52
                {
                    global::Windows.UI.Xaml.Controls.Button element8 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element8).Click += this.Eat_Op5_Click;
                }
                break;
            case 9: // EatPage.xaml line 44
                {
                    global::Windows.UI.Xaml.Controls.Button element9 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element9).Click += this.Eat_Op4_Click;
                }
                break;
            case 10: // EatPage.xaml line 36
                {
                    global::Windows.UI.Xaml.Controls.Button element10 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element10).Click += this.Eat_Op3_Click;
                }
                break;
            case 11: // EatPage.xaml line 28
                {
                    global::Windows.UI.Xaml.Controls.Button element11 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element11).Click += this.Eat_Op2_Click;
                }
                break;
            case 12: // EatPage.xaml line 20
                {
                    global::Windows.UI.Xaml.Controls.Button element12 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element12).Click += this.Eat_Op1_Click;
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
