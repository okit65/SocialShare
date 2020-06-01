using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ShareSample.Droid
{
	[Activity(Label = "ShareSample.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
        internal static MainActivity Instance { get; private set; }

        protected override void OnCreate(Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(bundle);

			global::Xamarin.Forms.Forms.Init(this, bundle);
            Instance = this;

            StrictMode.VmPolicy.Builder builder = new StrictMode.VmPolicy.Builder();
            builder.DetectFileUriExposure();

            StrictMode.SetVmPolicy(builder.Build());



            LoadApplication(new App());
		}
	}
}
