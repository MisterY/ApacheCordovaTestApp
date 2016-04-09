using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XFApp
{
    public class App : Application
    {
        public App()
        {
            var button = new Button
            {
                Text = "Click to open another page"
            };
            button.Clicked += (sender, args) =>
            {
                // open the new page
                var newPage = new FirstPage();
                App.Current.MainPage = newPage;
            };

            // The root page of your application
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                         new Label {
                             HorizontalTextAlignment = TextAlignment.Center,
                             Text = "Welcome to Xamarin Forms!"
                         },
                         button
                     }
                }
            };

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
