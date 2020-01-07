using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace UltimateConvertor
{
	public partial class NavPage : ContentPage
	{
   		public IList<WebPage> WebPages { get; private set; }
		public NavPage()
		{
			InitializeComponent();
			//Title = "Bonus Calculators";
			

			WebPages = new List<WebPage>();

			WebPages.Add(new WebPage { Name = "loan.html", Title = "Loan Calculator" });
			WebPages.Add(new WebPage { Name = "water_flow_calcs.html", Title = "Water Flow Calculator" });
			WebPages.Add(new WebPage { Name = "hp_calcs.html", Title = "Horsepower Calculator" });
			WebPages.Add(new WebPage { Name = "rectangles_and_boxes.html", Title = "Rectangle and Box Calculator" });
			WebPages.Add(new WebPage { Name = "circles_and_cylinders.html", Title = "Circle and Cylinder Calculator" });
			WebPages.Add(new WebPage { Name = "thermal_expansion_calculator.html", Title = "Thermal Expansion Calculator" });
			WebPages.Add(new WebPage { Name = "triangle.html", Title = "Right Triangle Calculator" });
			WebPages.Add(new WebPage { Name = "triangle2.html", Title = "Triangle Calculator" });

			
			BindingContext = this;
		}


		private void OnListViewItemTapped(object sender, SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem == null)
				return;
			
			WebPage SelectedPage = (WebPage)e.SelectedItem;
			var value = SelectedPage.GetName();
			var title = SelectedPage.GetTitle();
			var page = new WebViewPage(value, title);
			Navigation.PushAsync(page);
		}


		protected override void OnAppearing()
		{
			base.OnAppearing();
			listView.SelectedItem = null;
		}


		private void Button_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new About());
		}
	}
}

