using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace SillyAppLayout
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public abstract partial class Startup : Page
    {
        public Startup()
        {
            this.InitializeComponent();
            appTitle.Text = GetAppName();
            splashImage.Source = GetSplashSource();
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


    }
}
