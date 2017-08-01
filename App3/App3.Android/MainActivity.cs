using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

namespace App3.Droid
{
	[Activity (Label = "App3.Android", MainLauncher = true, Icon = "@drawable/icon" ,
        Theme ="@style/MyTheme" , LaunchMode= Android.Content.PM.LaunchMode.SingleTop)]
	public class MainActivity : AppCompatActivity
	{
		

               private Android.Support.V7.Widget.Toolbar toolbar;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            //sets the actionbar to our toolbar
            SetSupportActionBar(toolbar);
            //we can now call our toolbar via SupportActionBar
            SupportActionBar.Title = "Medicinopia";
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.action_menu, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            if (item.ItemId == Resource.Id.menu_alert)
            { StartActivity(typeof(AlertActivity)); }

            if (item.ItemId == Resource.Id.menu_rdv)
            { StartActivity(typeof(rdvActivity)); }

            if (item.ItemId == Resource.Id.menu_prelevement)
            { StartActivity(typeof(prelActivity)); }

            //Toast.MakeText(this, "Action selected: " + item.TitleFormatted,
            //ToastLength.Short).Show();

            return base.OnOptionsItemSelected(item);

            
        }
    }
	}



