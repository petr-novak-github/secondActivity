using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Widget;
using Android.Content;
using System;

namespace SecondActivityApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private Button _tlacitko1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
         
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            SetupReferencesPeno();
            SubscribeHandlersPeno();
           
        }
        private void SetupReferencesPeno()
        {
            
            _tlacitko1 = FindViewById<Button>(Resource.Id.button1);
        }

        private void SubscribeHandlersPeno()
        {
            _tlacitko1.Click += Tlacitko1_Click;
            
        }


        private void Tlacitko1_Click(object sender, System.EventArgs e)
        {
            var intent = new Intent(this, typeof(SecondActivity));
            StartActivity(intent);
        }
    }
}