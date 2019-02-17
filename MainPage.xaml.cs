using System;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Best_Of_Beijing
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            NavView.SelectedItem = "home";
        }
        private void NavView_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (NavigationViewItemBase item in NavView.MenuItems)
            {
                if (item is NavigationViewItem && item.Tag.ToString() == "home")
                {
                    NavView.SelectedItem = item;
                    break;
                }
            }
        }
        private void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            if (args.IsSettingsInvoked)
            {
                ContentFrame.Navigate(typeof(SettingsPage));
            }
            else
            {
                var item = sender.MenuItems.OfType<NavigationViewItem>().First(x => (string)x.Content == (string)args.InvokedItem);
                NavView_Navigate(item as NavigationViewItem);
            }
        }
        private void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected)
            {
                ContentFrame.Navigate(typeof(SettingsPage));
            }
            else
            {
                NavigationViewItem item = args.SelectedItem as NavigationViewItem;
                NavView_Navigate(item);
            }
        }
        private void NavView_Navigate(NavigationViewItem item)
        {   
            switch (item.Tag)
            {
                case "home":
                    ContentFrame.Navigate(typeof(HomePage));
                    break;
                case "settings":
                    ContentFrame.Navigate(typeof(SettingsPage));
                    break;   
                case "stay":
                    ContentFrame.Navigate(typeof(StayPage));
                    break;
                case "eat":
                    ContentFrame.Navigate(typeof(EatPage));
                    break;
                case "what":
                    ContentFrame.Navigate(typeof(WhatPage));
                    break;
                case "map":
                    ContentFrame.Navigate(typeof(MapPage));
                    break;
                case "news":
                    ContentFrame.Navigate(typeof(NewsPage));
                    break;
                case "weath":
                    ContentFrame.Navigate(typeof(WeatherPage));
                    break;
                default:
                    ContentFrame.Navigate(typeof(HomePage));
                    break;
            }
        }

    }
}
