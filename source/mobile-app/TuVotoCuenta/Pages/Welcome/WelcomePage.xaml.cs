﻿using TuVotoCuenta.ViewModels;
using Xamarin.Forms;

namespace TuVotoCuenta.Pages
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
			BindingContext = new WelcomeViewModel(this.Navigation);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();          
        }
    }
}