using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Controls.Maps;
using Windows.Devices.Geolocation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Best_Of_Beijing
{
    // You need to login to bing maps with microsoft acc and get key to use bing maps in xaml...!
    public sealed partial class MapPage : Page
    {
        //Beijing
        public BasicGeoposition Beijing = new BasicGeoposition() { Latitude = 39.9042, Longitude = 116.4074 };
        // Forbidden City
        public BasicGeoposition Place1 = new BasicGeoposition() { Latitude = 39.9163, Longitude = 116.3972 };
        // Great Wall   Badaling
        public BasicGeoposition Place2 = new BasicGeoposition() { Latitude = 40.3525, Longitude = 116.0042 };
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

        public MapPage()
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
        // use a known location
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            BasicGeoposition Beijing = new BasicGeoposition() { Latitude = 39.9052, Longitude = 116.4074 };            
            Geopoint cityCenter = new Geopoint(Beijing);

            MapControl1.Center = cityCenter;
            MapControl1.ZoomLevel = 9;
            MapControl1.LandmarksVisible = true;
            MapControl1.Heading = 360;
            MapControl1.Style = MapStyle.Road;
        }
        // buttons
        private void btnAerial_Click(object sender, RoutedEventArgs e)
        {
            MapControl1.Style = MapStyle.Aerial;
        }
        private void btnTraffic_Click(object sender, RoutedEventArgs e)
        {
            MapControl1.Style = MapStyle.Road;
        }
        private void btnNoTraffic_Click(object sender, RoutedEventArgs e)
        {
            MapControl1.Style = MapStyle.Aerial;
        }
        private void btnBusiness_Click(object sender, RoutedEventArgs e)
        {
            MapControl1.Style = MapStyle.Aerial;
        }
        private void btnAerialRoad_Click(object sender, RoutedEventArgs e)
        {
            MapControl1.Style = MapStyle.AerialWithRoads;
        }
        private void btnLandmarks_Click(object sender, RoutedEventArgs e)
        {
            MapControl1.LandmarksVisible = true;
        }
        private void btnNormal_Click(object sender, RoutedEventArgs e)
        {
            MapControl1.LandmarksVisible = true;
        }
    }
}
