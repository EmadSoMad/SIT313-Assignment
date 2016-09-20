﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace SIT313_Assignment2
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            MainPage = new NavigationPage(new Cart());
            
            //MainPage.BackgroundColor = Color.FromHex("#00162E");
           
           
            
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
