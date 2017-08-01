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
using Java.Util;

namespace App3.Droid
{
    [Activity(Label = "Prendre RDV2", ParentActivity = typeof(rdvActivity))]
    public class rdv2Activity : AppCompatActivity
    {
        private Android.Support.V7.Widget.Toolbar toolbar;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.newrdv2);

            // toolbarconfig
            toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
            SupportActionBar.Title = "Rendez-vous";
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.SetHomeButtonEnabled(true);

            // code d'envoie

            Button reserve = FindViewById<Button>(Resource.Id.reserve);

            reserve.Click += delegate
            {
                Toast.MakeText(this, " Demande de réservation envoyée !",
                ToastLength.Short).Show();

                Finish();
                StartActivity(typeof(MainActivity));
            };

        }
    }
}