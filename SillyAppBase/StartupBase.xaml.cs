using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media;

namespace SillyAppBase
{
    public abstract partial class StartupBase : PhoneApplicationPage
    {
        public StartupBase()
        {
            this.InitializeComponent();
            appTitle.Text = GetAppName();
            SplashImage.Source = GetSplashSource();
            StartButton.Click += StartButton_OnClick;
        }



        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        /// <summary>
        /// Returns the name of the app
        /// </summary>
        /// <returns></returns>
        public abstract String GetAppName();

        /// <summary>
        /// Returns the spalsh image displayed on the first page
        /// </summary>
        /// <returns></returns>
        public abstract ImageSource GetSplashSource();

        /// <summary>
        /// Return a URI pointing to the Quiz page of the app
        /// </summary>
        /// <returns></returns>
        public abstract Uri GetQuizPageUri();

        /// <summary>
        /// Click handler for start button. Goes to the quiz page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void StartButton_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(GetQuizPageUri());
        }
    }
}