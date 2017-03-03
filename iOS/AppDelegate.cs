using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

using Foundation;
using UIKit;

namespace PangyoDash.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			// Code for starting up the Xamarin Test Cloud Agent
#if ENABLE_TEST_CLOUD
			Xamarin.Calabash.Start();
#endif

			MobileCenter.Configure("5493e4a1-b2d2-45a8-9845-40794bc56032");
			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}
