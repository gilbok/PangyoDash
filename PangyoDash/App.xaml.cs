﻿using Xamarin.Forms;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

namespace PangyoDash
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new DashboardPage();
		}

		protected override void OnStart()
		{
			MobileCenter.Start(typeof(Analytics), typeof(Crashes));
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
