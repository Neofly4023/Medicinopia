using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V7.App;

namespace App3.Droid
{
    [Activity(Label = "Activity1" , ParentActivity = typeof(MainActivity))]
    public class prelActivity : AppCompatActivity
    {
        private Android.Support.V7.Widget.Toolbar toolbar;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.prelever);
            
            // toolbarconfig
            toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
            SupportActionBar.Title = "Prelevement";
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.SetHomeButtonEnabled(true);


            Button send = FindViewById<Button>(Resource.Id.send);
            send.Click += delegate
            {
                Toast.MakeText(this, " Prélèvements envoyés !",
                ToastLength.Short).Show();

                Finish();
            };
        }
    }
}