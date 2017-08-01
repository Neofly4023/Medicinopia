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
    [Activity(Label = "Prendre RDV", ParentActivity = typeof(MainActivity))]
    public class rdvActivity : AppCompatActivity
    {
        private Android.Support.V7.Widget.Toolbar toolbar;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.newrdv);
            
            // toolbarconfig
            toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
            SupportActionBar.Title = "Rendez-vous";
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.SetHomeButtonEnabled(true);

            // btn continuer
            Button next = FindViewById<Button>(Resource.Id.next);

            next.Click += delegate
            {
                StartActivity(typeof(rdv2Activity));
            };


        }
    }
}