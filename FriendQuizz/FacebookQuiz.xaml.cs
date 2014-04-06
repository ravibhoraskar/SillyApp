using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Facebook.Client;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using SillyAppBase;
using Facebook;

namespace Test
{
    public partial class FacebookQuiz : QuizBase
    {
        // For contacting Facebook app
        private static readonly string facebookAppId = "309130882567873";
        private static FacebookSessionClient FacebookSessionClient = new FacebookSessionClient(facebookAppId);

        // The accessToken, faceBookId, isAuthenticated flag returned by Facebook app
        private static string _accessToken = String.Empty;
        private static string _faceBookId = String.Empty;
        private static bool _isAuthenticated = false;

        public FacebookQuiz()
        {
            InitializeComponent();

            this.Loaded += FacebookLoginPage_Loaded;
        }

        /// <summary>
        /// This is called when the FaceBookQuiz xaml is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void FacebookLoginPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (!_isAuthenticated)
            {
                _isAuthenticated = true;
                await Authenticate();
            }
        }

        private FacebookSession session;
        private async Task Authenticate()
        {
            string message = String.Empty;
            try
            {
                session = await FacebookQuiz.FacebookSessionClient.LoginAsync("user_about_me,read_stream");
                _accessToken = session.AccessToken;
                _faceBookId = session.FacebookId;
            }
            catch (InvalidOperationException e)
            {
                message = "Login failed! Exception details: " + e.Message;
                MessageBox.Show(message);
            }
        }


    }
}