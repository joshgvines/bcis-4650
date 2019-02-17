using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Controls.Maps;
using Windows.Devices.Geolocation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Best_Of_Beijing
{
    public sealed partial class EatPage : Page
    {
        // Places to Eat
        //Beijing
        public BasicGeoposition Beijing = new BasicGeoposition() { Latitude = 39.9042, Longitude = 116.4074 };
        // Siji Minfu
        public BasicGeoposition Food1 = new BasicGeoposition() { Latitude = 39.9183, Longitude = 116.4088 };
        // Pecking Duck
        public BasicGeoposition Food2 = new BasicGeoposition() { Latitude = 39.9372, Longitude = 116.4441 };
        // Da Dong
        public BasicGeoposition Food3 = new BasicGeoposition() { Latitude = 39.9324, Longitude = 116.4310 };
        // Shi's
        public BasicGeoposition Food4 = new BasicGeoposition() { Latitude = 39.9434, Longitude = 116.3998 };
        // Huang Ting
        public BasicGeoposition Food5 = new BasicGeoposition() { Latitude = 39.9915, Longitude = 116.4164 };

        public EatPage()
        {
            this.InitializeComponent();

            Geopoint Loc1 = new Geopoint(Food1);
            MapIcon Pin1 = new MapIcon { Location = Loc1, NormalizedAnchorPoint = new Windows.Foundation.Point(0.5, 1.0), Title = "Siji Minfu", ZIndex = 0 };
            MapControl1.MapElements.Add(Pin1);

            Geopoint Loc2 = new Geopoint(Food2);
            MapIcon Pin2 = new MapIcon { Location = Loc2, NormalizedAnchorPoint = new Windows.Foundation.Point(0.5, 1.0), Title = "Pecking Duck", ZIndex = 0 };
            MapControl1.MapElements.Add(Pin2);

            Geopoint Loc3 = new Geopoint(Food3);
            MapIcon Pin3 = new MapIcon { Location = Loc3, NormalizedAnchorPoint = new Windows.Foundation.Point(0.5, 1.0), Title = "Da Dong", ZIndex = 0 };
            MapControl1.MapElements.Add(Pin3);

            Geopoint Loc4 = new Geopoint(Food4);
            MapIcon Pin4 = new MapIcon { Location = Loc4, NormalizedAnchorPoint = new Windows.Foundation.Point(0.5, 1.0), Title = "Shi's", ZIndex = 0 };
            MapControl1.MapElements.Add(Pin4);

            Geopoint Loc5 = new Geopoint(Food5);
            MapIcon Pin5 = new MapIcon { Location = Loc5, NormalizedAnchorPoint = new Windows.Foundation.Point(0.5, 1.0), Title = "Huang Ting", ZIndex = 0 };
            MapControl1.MapElements.Add(Pin5);   
        }
        private void Eat_Op1_Click(object sender, RoutedEventArgs e)
        {
            Geopoint GoTo1 = new Geopoint(Food1);
            MapControl1.Style = MapStyle.Road;
            MapControl1.Center = GoTo1;
            MapControl1.ZoomLevel = 14;
            MapControl1.Heading = 360;
            info.Text = "     Near the Forbidden City. " +
                "This dining spot gets great reviews with a great menu and many options. " +
                "Family friendly, good for large groups or small parties. " +
                "Your hotel may be able to help with reservations of large groups. " +
                "Try the roast duck and especially the duck tacos."; 
        }
        private void Eat_Op2_Click(object sender, RoutedEventArgs e)
        {
            Geopoint GoTo2 = new Geopoint(Food2);
            MapControl1.Style = MapStyle.Road;
            MapControl1.Center = GoTo2;
            MapControl1.ZoomLevel = 14;
            MapControl1.Heading = 360;
            info.Text = "     Peking Duck is the one dish that you absolutely shouldn't miss. " +
                "A dish that has been prepared for centuries since Imperial times. " +
                "This casual dining is always at the top of travelers lis for the best Peking duck for the price.";
        }
        private void Eat_Op3_Click(object sender, RoutedEventArgs e)
        {
            Geopoint GoTo3 = new Geopoint(Food3);
            MapControl1.Style = MapStyle.Road;
            MapControl1.Center = GoTo3;
            MapControl1.ZoomLevel = 14;
            MapControl1.Heading = 360;
            info.Text = "     Fine dining and always in the top 10 of Beijing’s Restaurant Awards. " +
                "Try the duck pancakes and the sea cucumbers or of course their version of Peking Duck. " +
                "Picture menu available.";
        }
        private void Eat_Op4_Click(object sender, RoutedEventArgs e)
        {
            Geopoint GoTo4 = new Geopoint(Food4);
            MapControl1.Style = MapStyle.Road;
            MapControl1.Center = GoTo4;
            MapControl1.ZoomLevel = 15;
            MapControl1.Heading = 360;
            info.Text = "     Relaxed atmosphere of authentic and delicious fried or steamed dumplings. " +
                "The menu is extensive any combo of flavors. " +
                "They also offer dessert dumplings. Vegetarian friendly.";
        }
        private void Eat_Op5_Click(object sender, RoutedEventArgs e)
        {
            Geopoint GoTo5 = new Geopoint(Food5);
            MapControl1.Style = MapStyle.Road;
            MapControl1.Center = GoTo5;
            MapControl1.ZoomLevel = 15;
            MapControl1.Heading = 360;
            info.Text = "     Elegant fine dining. A superb list of Chinese wines and Liquors. " +
                "This restaurant boasts a Tea Lounge with its very own Tea Master. " +
                "This restaurant recreates a traditional nobleman's courtyard home and the tea lounge aan ancient Ming Dynasty Palace. " +
                "Reservations recommended.";
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // Beijing
            Geopoint cityCenter = new Geopoint(Beijing);
            MapControl1.Style = MapStyle.Road;
            MapControl1.Center = cityCenter;
            MapControl1.ZoomLevel = 8;
            MapControl1.Heading = 360;
            info.Text = "     Take a look at some great places to eat in Beijing above. ";
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
            info.Text = "     Take a look at some great places to eat in Beijing above. ";
        }
    }
}
