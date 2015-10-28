using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServiceStack;
using Xamarin.Forms;


// https://bugzilla.xamarin.com/show_bug.cgi?id=24679   <--!!!

namespace ssforms
{
    public class App : Application
    {
         
        public App()
        {
           
            // The root page of your application
            
            MainPage = new Login();

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
