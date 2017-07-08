using System;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

using Xamarin.Forms;
using System.Collections.Generic;

namespace WebViewSample
{
	public class LinkToInAppCode : ContentPage
	{
		public LinkToInAppCode ()
		{
			this.Title = "アプリ内ブラウザのデモ";
			this.Padding = new Thickness (10);

			var layout = new StackLayout ();

			var label = new Label () {
				Text = "これは、ユーザーに良い経験を与えながら、あなたのアプリを離れることなくリンクを開く方法を示しています。"
            };

			var button = new Button (){ Text = "黒部峡谷鉄道に移動する" };
			button.Clicked += navButtonClicked;

			layout.Children.Add (label);
			layout.Children.Add (button);
			Content = layout;
		}

		/// <summary>
		/// launches the browser window
		/// </summary>
		void navButtonClicked (object sender, EventArgs e)
		{
            Analytics.Enabled = true;
            Analytics.TrackEvent("ItemsPage appearing.", new Dictionary<string, string> { { "Category", "Trace" } });
            this.Navigation.PushAsync (new InAppBrowserCode ("http://www.kurotetu.co.jp/"));
        }
	}
}


