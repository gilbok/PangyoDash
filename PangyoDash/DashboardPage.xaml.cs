using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PangyoDash
{
	public partial class DashboardPage : ContentPage
	{
		static void ShowMyLocation_Clicked(DashboardPage instance, object sender, System.EventArgs e)
		{
			if (Device.OS == TargetPlatform.iOS)
			{
				//https://developer.apple.com/library/ios/featuredarticles/iPhoneURLScheme_Reference/MapLinks/MapLinks.html
				Device.OpenUri(new Uri("http://maps.apple.com/?q=394+Pacific+Ave+San+Francisco+CA"));
			}
			else if (Device.OS == TargetPlatform.Android)
			{
				// opens the Maps app directly
				Device.OpenUri(new Uri("geo:0,0?q=394+Pacific+Ave+San+Francisco+CA"));

			}
			else if (Device.OS == TargetPlatform.Windows || Device.OS == TargetPlatform.WinPhone)
			{
				Device.OpenUri(new Uri("bingmaps:?where=394 Pacific Ave San Francisco CA"));
			}
		}

		public DashboardPage()
		{
			InitializeComponent();
		}
	}
}
