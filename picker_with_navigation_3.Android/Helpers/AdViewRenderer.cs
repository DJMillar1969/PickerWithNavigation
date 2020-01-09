﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;
using Android.Gms.Ads;
using Xamarin.Forms;
using UltimateConvertor.Controls;
using UltimateConvertor.Droid.Helpers;


[assembly: ExportRenderer(typeof(UltimateConvertor.Controls.AdControlView), typeof(UltimateConvertor.Droid.Helpers.AdViewRenderer))]
namespace UltimateConvertor.Droid.Helpers
{

	public class AdViewRenderer : ViewRenderer<Controls.AdControlView, AdView>
	{
		public AdViewRenderer(Context context) : base(context) { }

		protected override void OnElementChanged(ElementChangedEventArgs<AdControlView> e)
		{
			base.OnElementChanged(e);

			if (e.NewElement != null && Control == null)
				SetNativeControl(CreateAdView());
		}

		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);

			if (e.PropertyName == nameof(AdView.AdUnitId))
			{
				Control.AdUnitId = "ca-app-pub-1884504687379461/2724319156"; // use this for Ultimate Converter 
				//Control.AdUnitId = "ca-app-pub-3940256099942544/6300978111"; // use this id for testing
			}
		}

		private AdView CreateAdView()
		{
			var adView = new AdView(Context)
			{
				AdSize = AdSize.Banner,
				AdUnitId = "ca-app-pub-1884504687379461/2724319156"  // use this for Ultimate Converter 
				//AdUnitId = "ca-app-pub-3940256099942544/6300978111" // use this id for testing


			};

			adView.LayoutParameters = new LinearLayout.LayoutParams(LayoutParams.MatchParent, LayoutParams.MatchParent);

			adView.LoadAd(new AdRequest.Builder().Build());

			return adView;
		}
	}
}