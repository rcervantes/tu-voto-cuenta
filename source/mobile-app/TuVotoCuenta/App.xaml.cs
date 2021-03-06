﻿using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using TuVotoCuenta.Domain;
using TuVotoCuenta.Pages;
using Xamarin.Forms;

namespace TuVotoCuenta
{
    public partial class App : Application
    {
		public static double ScreenWidth;
		public static double ScreenHeight;
        
		public static double Latitude;
        public static double Longitude;

		public App()
        {
            InitializeComponent();

            //set startup app configuration
            SettingsInitializer.InitSettings();
            Microsoft.AppCenter.AppCenter.Start($"ios={Settings.AppCenterIOS};android={Settings.AppCenterDroid}", typeof(Analytics), typeof(Crashes));


			//if logged in redirect to main page
            if (Settings.Profile_Username != string.Empty)
                Application.Current.MainPage = new MasterPage() { IsPresented = true };
            else
                MainPage = new SignUpPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}