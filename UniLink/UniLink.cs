using System;

using Xamarin.Forms;

namespace UniLink
{
    public class App : Application
    {
        private Label _label;

        public App()
        {
            _label = new Label()
            {
                HorizontalTextAlignment = TextAlignment.Center,
                Text = "Welcome to Xamarin Forms!"
            };

            // The root page of your application
            var content = new ContentPage
            {
                Title = "UniLink",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = { _label }
                }
            };

            MainPage = new NavigationPage(content);
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

		protected override void OnAppLinkRequestReceived(Uri uri)
		{
            _label.Text = "Xamarin Forms opened through App Link!";

            base.OnAppLinkRequestReceived(uri);
		}
	}
}
