﻿using Android.App;
using Android.Widget;
using Android.OS;

namespace VedicsSangrah
{
    [Activity(Label = "VedicsSangrah", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            Button button1 = FindViewById<Button>(Resource.Id.ChalisaSangrahButton);
            button1.Click += delegate
             {
                 StartActivity(typeof(ChalisaSangrah));
             };

        }
    }
}
