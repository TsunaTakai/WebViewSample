using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using Xamarin.Forms;

namespace WebViewSample
{
    public class App : Application
    {
        public App()
        {
			var tabs = new TabbedPage ();
			var navPage = new NavigationPage () {Title= "アプリコンテンツ" };
			tabs.Children.Add (navPage);

			bool useXaml = false; //change this to use the code implementation

			if (useXaml) {
				
				navPage.PushAsync (new LinkToInAppXaml ());
				tabs.Children.Add (new LoadingLabelXaml ());
			} else {
				navPage.PushAsync (new LinkToInAppCode ());
				tabs.Children.Add (new LoadingLabelCode ());
			}

			MainPage = tabs;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            MobileCenter.Start("android=db116159-5ef0-4124-9ce6-05a9e43f7619;" +
                   "ios=6edfbb27-167f-44bc-99e8-0a1b840113b7;",
                   typeof(Analytics), typeof(Crashes));
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
