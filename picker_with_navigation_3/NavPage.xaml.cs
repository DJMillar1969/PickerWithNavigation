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
			Title = "Bonus Calculators";

			WebPages = new List<WebPage>();

			WebPages.Add(new WebPage { Name = "loan.html", Title = "Loan Calculator" });
			WebPages.Add(new WebPage { Name = "water_flow_calcs.html", Title = "Water Flow Calc's" });
			WebPages.Add(new WebPage { Name = "hp_calcs.html", Title = "Horsepower Calc's" });
			WebPages.Add(new WebPage { Name = "rectangles_and_boxes.html", Title = "Rectangle and Box Calc's" });
			WebPages.Add(new WebPage { Name = "circles_and_cylinders.html", Title = "Circle and Cylinder Calc's" });
			WebPages.Add(new WebPage { Name = "thermal_expansion_calculator.html", Title = "Thermal Expansion Calc's" });
			WebPages.Add(new WebPage { Name = "triangle.html", Title = "Right Triangle Calculator" });
			WebPages.Add(new WebPage { Name = "triangle2.html", Title = "Triangle Calculator" });
			Button button = new Button
			{
				Text = "About",
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Center
			};
			button.Clicked += async (sender, args) => await Navigation.PushAsync(new About());

			var layout = new StackLayout();
			layout.Children.Add(listView);
			layout.Children.Add(button);
			layout.Padding = new Thickness(20, 20, 20, 0);
			Content = layout;

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

	}
}

