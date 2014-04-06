using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Test.Resources;
using Facebook;

namespace Test
{
    public partial class MainPage  
    {
        private string appName = "FriendSeek";
        private string imageUri = "http://www.flickitup.com/gallery/images_files/1275675604.jpg";//"ms-appx:///Assets/Images/SillyCats.jpg";
        private string quizPageUri = "/FacebookQuiz.xaml";

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
        public override string GetAppName()
        {
            return this.appName;
        }

        public override ImageSource GetSplashSource()
        {
            return new BitmapImage(new Uri(this.imageUri, UriKind.RelativeOrAbsolute));
        }

        public override Uri GetQuizPageUri()
        {
            return new Uri(this.quizPageUri,UriKind.RelativeOrAbsolute);
        }
    }
}