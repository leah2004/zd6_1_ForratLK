﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace forrat66
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SecondPage();
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
