using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Best_Of_Beijing
{
    public sealed partial class StayPage : Page
    {
        public StayPage()
        {
            this.InitializeComponent();
            Uri myUri = new Uri("http://waldorfastoria3.hilton.com/en/hotels/china/waldorf-astoria-beijing-BJSWAWA/index.html");
            webView1.Source = (myUri);
        }
        private void Stay_Op1_Click(object sender, RoutedEventArgs e)
        {
            Uri myUri = new Uri("http://waldorfastoria3.hilton.com/en/hotels/china/waldorf-astoria-beijing-BJSWAWA/index.html");
            webView1.Source = (myUri);
        }
        private void Stay_Op2_Click(object sender, RoutedEventArgs e)
        {
            Uri myUri = new Uri("https://beijing.newworldhotels.com/en/");
            webView1.Source = (myUri);
        }
        private void Stay_Op3_Click(object sender, RoutedEventArgs e)
        {
            Uri myUri = new Uri("http://www.legendalehotel.com/");
            webView1.Source = (myUri);
        }
        private void Stay_Op4_Click(object sender, RoutedEventArgs e)
        {
            Uri myUri = new Uri("https://www.nuohotel.com/");
            webView1.Source = (myUri);
        }
        private void Stay_Op5_Click(object sender, RoutedEventArgs e)
        {
            Uri myUri = new Uri("http://www3.hilton.com/en/hotels/china/hilton-beijing-wangfujing-BJSWFHI/index.html");
            webView1.Source = (myUri);
        }
        private void Stay_Op6_Click(object sender, RoutedEventArgs e)
        {
            Uri myUri = new Uri("http://www.regenthotels.com/regent-beijing");
            webView1.Source = (myUri);
        }
        private void Stay_Op7_Click(object sender, RoutedEventArgs e)
        {
            Uri myUri = new Uri("http://beijing.peninsula.com/en/default");
            webView1.Source = (myUri);
        }
        private void webView1_LoadCompleted(object sender, NavigationEventArgs e)
        {
            
        }
    } 
}
