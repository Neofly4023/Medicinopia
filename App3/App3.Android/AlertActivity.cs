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
using Android.Support.V4.App;

namespace App3.Droid
{
    [Activity(Label = "Signaler" , ParentActivity = typeof(MainActivity))]
    public class AlertActivity : AppCompatActivity
    {
        private Android.Support.V7.Widget.Toolbar toolbar;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.alert);


            //toolbar config
            toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
            SupportActionBar.Title = "Signaler";
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.SetHomeButtonEnabled(true);

            // fab code

            var fab = FindViewById<Android.Support.Design.Widget.FloatingActionButton>(Resource.Id.fab);

            fab.Click += delegate
            {
                Toast.MakeText(this, " Message envoyé !",
                ToastLength.Short).Show();

                Finish();
                //StartActivity(typeof(MainActivity));
            };

        }


        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            if (item.ItemId == Resource.Id.home) NavUtils.NavigateUpFromSameTask(this);
            //{ Finish();  }

            return base.OnOptionsItemSelected(item);
        }

        /* public boolean onOptionsItemSelected(MenuItem item)
         {
             switch (item.getItemId())
             {

                 case android.R.id.home:
                     onBackPressed();
                     return true;
             }

             return super.onOptionsItemSelected(item);
         } */
    }
}