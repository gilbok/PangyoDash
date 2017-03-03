using System;

using Xamarin.Forms;

namespace PangyoDash
{
	public class LocationViewPage : ContentPage
	{
		public LocationViewPage()
		{
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}

