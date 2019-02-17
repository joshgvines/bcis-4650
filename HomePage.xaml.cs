using System;
using Microsoft.QueryStringDotNET;
using Microsoft.Toolkit.Uwp.Notifications;
using Windows.UI.Notifications;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Best_Of_Beijing
{
    public sealed partial class HomePage : Page
    {
        public HomePage()
        {
            this.InitializeComponent();
            string videoID = "Iu6xR1BZi3s";                       
            string html = @"<iframe width=""774"" height=""480"" src=""http://www.youtube.com/embed/" + videoID + @"?rel=0""> </iframe>"; 
            this.webView.NavigateToString(html);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string title = "Welcome To Best of Beijing!";
            string content = "Hope you enjoy this app!";
            string image = "Image Content";
            string logo = "Logo";
            int conversationId = 384928;

            ToastVisual visual = new ToastVisual()
            {
                BindingGeneric = new ToastBindingGeneric()
                {
                    Children =
                    {
                         new AdaptiveText()
                         {
                             Text = title
                         },
                         new AdaptiveText()
                         {
                             Text = content
                         },
                         new AdaptiveImage()
                         {
                             Source = image
                         }
                    },
                    AppLogoOverride = new ToastGenericAppLogo()
                    {
                        Source = logo,
                        HintCrop = ToastGenericAppLogoCrop.Circle
                    }
                }
            };
            ToastActionsCustom actions = new ToastActionsCustom()
            {
                Inputs =
                    {
                        new ToastTextBox("tbReply")
                        {
                            PlaceholderContent = "Type a response"
                        }
                    },
                Buttons =
                {
                    new ToastButton("Reply", new QueryString()
                    {
                        { "action", "reply" },
                        { "conversationId", conversationId.ToString() }

                    }.ToString())
                    {
                        ActivationType = ToastActivationType.Background,
                        ImageUri = "Assets/Reply.png",
                        TextBoxId = "tbReply"
                    },
                    new ToastButton("Like", new QueryString()
                    {
                        { "action", "like" },
                        { "conversationId", conversationId.ToString() }
                    }.ToString())
                    {
                        ActivationType = ToastActivationType.Background
                    },
                    new ToastButton("View", new QueryString()
                    {
                        { "action", "viewImage" },
                        { "imageUrl", image }

                    }.ToString())
                }
            };
            ToastContent toastContent = new ToastContent()
            {
                Visual = visual,
                Actions = actions,

                Launch = new QueryString()
                {
                    { "action", "viewConversation" },
                    { "conversationId", conversationId.ToString() }
                }.ToString()
            };
            ToastNotification notification = new ToastNotification(toastContent.GetXml());
            ToastNotificationManager.CreateToastNotifier().Show(notification);
        }
    }     
}