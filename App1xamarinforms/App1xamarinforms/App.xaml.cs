﻿using App1xamarinforms.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1xamarinforms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new LoginTabbedPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
