using UltimateConvertor;
using UltimateConvertor.Controls;
using UltimateConvertor.iOS;

using Google.MobileAds;
using System.ComponentModel;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using UltimateConvertor.iOS.renderers;

[assembly: ExportRenderer(typeof(AdControlView), typeof(AdMobViewRenderer))]
namespace UltimateConvertor.iOS.renderers
{
	public class AdMobViewRenderer : ViewRenderer<AdControlView, BannerView>
	{
		protected override void OnElementChanged(ElementChangedEventArgs<AdControlView> e)
		{
			base.OnElementChanged(e);

			if (e.NewElement != null && Control == null)
				SetNativeControl(CreateBannerView());
		}

		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);

			if (e.PropertyName == nameof(BannerView.AdUnitID))
				Control.AdUnitID = "ca-app-pub-1884504687379461/8140634070";
		}

		private BannerView CreateBannerView()
		{
			var bannerView = new BannerView(AdSizeCons.SmartBannerPortrait)
			{
				AdUnitID = "ca-app-pub-1884504687379461/8140634070",
				RootViewController = GetVisibleViewController()
			};

			bannerView.LoadRequest(GetRequest());

			Request GetRequest()
			{
				var request = Request.GetDefaultRequest();
				return request;
			}

			return bannerView;
		}

		private UIViewController GetVisibleViewController()
		{
			var windows = UIApplication.SharedApplication.Windows;
			foreach (var window in windows)
			{
				if (window.RootViewController != null)
				{
					return window.RootViewController;
				}
			}
			return null;
		}
	}
}