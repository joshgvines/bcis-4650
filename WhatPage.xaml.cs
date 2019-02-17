using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Controls.Maps;
using Windows.Devices.Geolocation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Best_Of_Beijing
{
    public sealed partial class WhatPage : Page
    {
        // Locations
        //Beijing
        public BasicGeoposition Beijing = new BasicGeoposition() { Latitude = 39.9042, Longitude = 116.4074 };
        // Forbidden City
        public BasicGeoposition Place1 = new BasicGeoposition() { Latitude = 39.9163, Longitude = 116.3972 };
        // Great Wall   Badaling
        public BasicGeoposition Place2 = new BasicGeoposition() { Latitude = 40.3525 , Longitude = 116.0042 };
        // Temple of Heaven
        public BasicGeoposition Place3 = new BasicGeoposition() { Latitude = 39.8822, Longitude = 116.4066 };
        // Summer Palace
        public BasicGeoposition Place4 = new BasicGeoposition() { Latitude = 39.9990, Longitude = 116.2741 };
        // Tiananmen Square
        public BasicGeoposition Place5 = new BasicGeoposition() { Latitude = 39.9054, Longitude = 116.3976 };
        // Ming Tombs
        public BasicGeoposition Place6 = new BasicGeoposition() { Latitude = 40.2551, Longitude = 116.2235 };
        // Jingshan Park
        public BasicGeoposition Place7 = new BasicGeoposition() { Latitude = 39.9251, Longitude = 116.3968 };

        public WhatPage()
        {
            this.InitializeComponent();
 
            Geopoint Loc1 = new Geopoint(Place1);
            MapIcon Pin1 = new MapIcon { Location = Loc1, NormalizedAnchorPoint = new Windows.Foundation.Point(0.5, 1.0), Title = "Forbidden City", ZIndex = 0 };
            MapControl1.MapElements.Add(Pin1);

            Geopoint Loc2 = new Geopoint(Place2);
            MapIcon Pin2 = new MapIcon { Location = Loc2, NormalizedAnchorPoint = new Windows.Foundation.Point(0.5, 1.0), Title = "Great Wall Badaling", ZIndex = 0 };
            MapControl1.MapElements.Add(Pin2);

            Geopoint Loc3 = new Geopoint(Place3);
            MapIcon Pin3 = new MapIcon { Location = Loc3, NormalizedAnchorPoint = new Windows.Foundation.Point(0.5, 1.0), Title = "Temple of Heaven", ZIndex = 0 };
            MapControl1.MapElements.Add(Pin3);

            Geopoint Loc4 = new Geopoint(Place4);
            MapIcon Pin4 = new MapIcon { Location = Loc4, NormalizedAnchorPoint = new Windows.Foundation.Point(0.5, 1.0), Title = "Summer Palace", ZIndex = 0 };
            MapControl1.MapElements.Add(Pin4);

            Geopoint Loc5 = new Geopoint(Place5);
            MapIcon Pin5 = new MapIcon { Location = Loc5, NormalizedAnchorPoint = new Windows.Foundation.Point(0.5, 1.0), Title = "Tiananmen Square", ZIndex = 0 };
            MapControl1.MapElements.Add(Pin5);
 
            Geopoint Loc6 = new Geopoint(Place6);
            MapIcon Pin6 = new MapIcon { Location = Loc6, NormalizedAnchorPoint = new Windows.Foundation.Point(0.5, 1.0), Title = "Ming Tombs", ZIndex = 0 };
            MapControl1.MapElements.Add(Pin6);

            Geopoint Loc7 = new Geopoint(Place7);
            MapIcon Pin7 = new MapIcon { Location = Loc7, NormalizedAnchorPoint = new Windows.Foundation.Point(0.5, 1.0), Title = "Jingshan Park", ZIndex = 0 };
            MapControl1.MapElements.Add(Pin7);
        }
        private void What_Op1_Click(object sender, RoutedEventArgs e)
        {
            Geopoint GoTo1 = new Geopoint(Place1);
            MapControl1.Style = MapStyle.Road;
            MapControl1.Center = GoTo1;
            MapControl1.ZoomLevel = 14;
            MapControl1.Heading = 360;
            content.Text = "     The Forbidden City is a must see while in Beijing. " +
                "It is a World Heritage Site and one of the most visited ancient sites in the world. " +
                "The Forbidden City was built from 1406 to 1420 and was the home to 24 past Emperors from the Ming Dynasty up to the end of the Qing Dynasty. " +
                "It is now home to one of the worlds largest museums, The Palace Museum. " +
                "Also, Tiananmen Square and Jingshan Park are very close by, this would be great way to see multiple sites in the same day.";
        }
        private void What_Op2_Click(object sender, RoutedEventArgs e)
        {
            Geopoint GoTo2 = new Geopoint(Place2);
            MapControl1.Style = MapStyle.Road;
            MapControl1.Center = GoTo2;
            MapControl1.ZoomLevel = 14;
            MapControl1.Heading = 360;
            content.Text = "     China’s most popular place to visit is The Great Wall of China, it is one of the seven wonders of the world with more than 10 million visitors a year. " +
                "It is approximately 13000 miles in length and it’s history dates back 2300 years.The most popular sections to visit are near Beijing listed as follows: \n" +
                "\n -  Badaling is the most common place for tourists." +
                "\n -  Mutianyu a beautiful fully restored area " +
                "\n -  Jinshaning a popular hike and impressive architecture " +
                "\n -  Jiankou postcard picturesque steep inclines.";
        }
        private void What_Op3_Click(object sender, RoutedEventArgs e)
        {
            Geopoint GoTo3 = new Geopoint(Place3);
            MapControl1.Style = MapStyle.Road;
            MapControl1.Center = GoTo3;
            MapControl1.ZoomLevel = 14;
            MapControl1.Heading = 360;
            content.Text = "     Easily reached by subway. " +
                "This park is a large complex of temples and gardens that were built in 1420 during the Ming dynasty, " +
                "It is where emperors of the Ming and Qing dynasties visited for annual ceremonies to pray for good harvests. " +
                "It is a masterpiece of the Ming and Qing architectural art. " +
                "Try joining some locals for tai chi here in the middle square.";
        }
        private void What_Op4_Click(object sender, RoutedEventArgs e)
        {
            Geopoint GoTo4 = new Geopoint(Place4);
            MapControl1.Style = MapStyle.Road;
            MapControl1.Center = GoTo4;
            MapControl1.ZoomLevel = 15;
            MapControl1.Heading = 360;
            content.Text = "     Summer Palace is another Beijing favorite with easy Metro access from downtown Beijing. " +
                "It is a masterpiece of Chinese landscape and garden design. The Chinese call it Yihe Yuan, 'Garden of Restful Peace'. " +
                "The Imperial families spent their summers here instead of at the Forbidden City. \n" +
                "\n Be sure to take a Dragon boat ride on Kunming Lake!";
        }
        private void What_Op5_Click(object sender, RoutedEventArgs e)
        {
            Geopoint GoTo5 = new Geopoint(Place5);
            MapControl1.Style = MapStyle.Road;
            MapControl1.Center = GoTo5;
            MapControl1.ZoomLevel = 15;
            MapControl1.Heading = 360;
            content.Text = "     Tiananmen Square is located in the center of Beijing, and in front of the Forbidden City. " +
                "Tiananmen means 'gate of heavenly peace'. " +
                "Here you can visit the Monument to the People’s heroes, the Great Hall of the People, " +
                "China Railway Museum and the National Museum of China.";
        }
        private void What_Op6_Click(object sender, RoutedEventArgs e)
        {
            Geopoint GoTo6 = new Geopoint(Place6);
            MapControl1.Style = MapStyle.Road;
            MapControl1.Center = GoTo6;
            MapControl1.ZoomLevel = 15;
            MapControl1.Heading = 360;
            content.Text = "     Ming Tombs also known as The Thirteen Tombs of Ming Dynasty are located near Beijing in a scenic area at the Southern foot of Tiānshòu Mountain. " +
                "It is a collection of mausoleums built by the Ming Dynasty Emperors. Leading up to the tombs is another must see, Sacred Way or Divine Road that leads to heaven. " +
                "Allow at least a half day trip and 3 of the tombs remain open to visitors.";
        }
        private void What_Op7_Click(object sender, RoutedEventArgs e)
        {
            Geopoint GoTo7 = new Geopoint(Place7);
            MapControl1.Style = MapStyle.Road;
            MapControl1.Center = GoTo7;
            MapControl1.ZoomLevel = 15;
            MapControl1.Heading = 360;
            content.Text = "     Want a 360 degree view of Beijing, then visit Jingshan Park overlooking the Forbidden City.  " +
                "It is a luscious 57 acre garden in the middle of Beijing. The hill inside Jingshan Park has five summits and a tremendous view from the top summit. " +
                "Take in a sunset at the top, the temple on top is called the Pavilion of Everlasting Spring.";
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // Beijing
            Geopoint cityCenter = new Geopoint(Beijing);
            MapControl1.Style = MapStyle.Road;
            MapControl1.Center = cityCenter;
            MapControl1.ZoomLevel = 8;
            MapControl1.Heading = 360;
            content.Text = "     Beijing is a top destination for business and pleasure travel. " +
                "This city affords much to do and offers easy transportation by airplane, bullet train, subway and bus as well as bicycle. " +
                "The climate is similar to the US city of Washington DC with the same seasons. World class accommodations and dining are plentiful. " +
                "Beijing is considered the gateway for most who want to see the Great Wall but also offers many attractions and examples of ancient Chinese history and architecture. " +
                "Try and allow at least three days to take in the many sites.";  
        }
        // Map Control Buttons
        private void btnAerial_Click(object sender, RoutedEventArgs e)
        {
            MapControl1.Style = MapStyle.Aerial;
        }
        private void btnAerialRoad_Click(object sender, RoutedEventArgs e)
        {
            MapControl1.Style = MapStyle.AerialWithRoads;
        }
        private void btnDefault_Click(object sender, RoutedEventArgs e)
        {
            MapControl1.Style = MapStyle.None;
            MapControl1.Style = MapStyle.Road;
            MapControl1.LandmarksVisible = true;
        }
        private void btnBeijing_Click(object sender, RoutedEventArgs e)
        {
            Geopoint RstCity = new Geopoint(Beijing);
            MapControl1.Style = MapStyle.Road;
            MapControl1.Center = RstCity;
            MapControl1.ZoomLevel = 8;
            MapControl1.Heading = 360;
            content.Text = "     Beijing is a top destination for business and pleasure travel. " +
                "This city affords much to do and offers easy transportation by airplane, bullet train, subway and bus as well as bicycle. " +
                "The climate is similar to the US city of Washington DC with the same seasons. World class accommodations and dining are plentiful. " +
                "Beijing is considered the gateway for most who want to see the Great Wall but also offers many attractions and examples of ancient Chinese history and architecture. " +
                "Try and allow at least three days to take in the many sites.";
        }
    }
}

