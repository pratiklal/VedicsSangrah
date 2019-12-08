﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Webkit;

namespace VedicsSangrah
{
    [Activity(Label = "अष्ट लक्ष्मी स्तोत्र")]
    public class Aashtalaxmistotra : Activity
    {
        WebView Aashtalaxmistotrawebview;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Ashtalaxmistotra);
            Aashtalaxmistotrawebview = FindViewById<WebView>(Resource.Id.AashtalaxmistotrawebView1);
            Aashtalaxmistotrawebview.SetWebViewClient(new WebViewClient());
            Aashtalaxmistotrawebview.Settings.JavaScriptEnabled = true;
            Aashtalaxmistotrawebview.LoadUrl("file:///android_asset/stotram/ashtalaxmistotra.htm");

        }
    }
}