using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.Web.Syndication;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Best_Of_Beijing
{
    public class NewsFeed
    {
        private async void Load(ItemsControl list, Uri uri)
        {
            SyndicationClient client = new SyndicationClient();
            SyndicationFeed feed = await client.RetrieveFeedAsync(uri);
            if (feed != null)
            {
                foreach (SyndicationItem item in feed.Items)
                {
                    list.Items.Add(item);
                }
            }
        }
        public void Go(ref ItemsControl list, string value, KeyRoutedEventArgs args)
        {
            if (args.Key == Windows.System.VirtualKey.Enter)
            {
                try
                {
                    Load(list, new Uri(value));
                }
                catch
                {

                }
                list.Focus(FocusState.Keyboard);
            }
        }
    }
    public sealed partial class NewsPage : Page
    {
        public NewsPage()
        {
            this.InitializeComponent();
        }
        public NewsFeed MyFeed = new NewsFeed();
        public string address = "http://www.chinadaily.com.cn/rss/china_rss.xml";

        private void Go_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            MyFeed.Go(ref Display, address, e);
        }
        private void Address_OnTapped(object sender, TappedRoutedEventArgs e)
        {
            var tblk = sender as TextBlock;
            Uri targetUri = new Uri(tblk.Text);
            ArticleWebView.Navigate(targetUri);
        }
    }
}


