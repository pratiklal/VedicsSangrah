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
    [Activity(Label = "श्री कृष्ण जी की आरती")]
    public class KrishnaAarti : Activity
    {
        WebView KrishnaAartiWebView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.KrishnaAarti);
            KrishnaAartiWebView = FindViewById<WebView>(Resource.Id.KrishnaAartiwebView1);
            KrishnaAartiWebView.SetWebViewClient(new WebViewClient());
            KrishnaAartiWebView.Settings.JavaScriptEnabled = true;
            KrishnaAartiWebView.LoadUrl("file:///android_asset/aarti/KrishnaAarti.htm");
        }
    }
}