﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExemploXamarinGithubActions
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

            var test = "test";
            Console.WriteLine(test);
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
