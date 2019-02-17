using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Best_Of_Beijing
{
    public sealed partial class WeatherPage : Page
    {     
        public WeatherPage()
        {
            this.InitializeComponent();
        }
        
        // Button to Get Weather
        private async void BtnGetWeather(object sender, RoutedEventArgs e)
        {
            RootObject myWeather = await WeatherProxy.GetWeather(20.0, 30.0);
            // Title
            TitleBlock.Text = myWeather.name + " - " + myWeather.weather[0].description;

            // Temp
            TempCurBlock.Text = ((int)myWeather.main.temp).ToString() + " F";
 
            // Feel
            HumidBlock.Text = "- Humidity:  " + ((int)myWeather.main.humidity).ToString() + " %";
            DescBlock.Text = "- Condition:  " + myWeather.weather[0].description;
            PressBlock.Text = "- Wind:  " + myWeather.wind.speed + " m/h";
        }    
    }   
}
