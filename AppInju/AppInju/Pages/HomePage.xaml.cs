using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppInju
{
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();
		}

		async void RequestCardClicked(object sender, EventArgs args)
		{
			await this.Navigation.PushAsync(new CardRequestPage());
		}

		async void DiscountAndBenefitsClicked(object sender, EventArgs args)
		{
			await this.Navigation.PushAsync(new BenefitsAndDiscountsPage());
		}

		async void DiscountsAndBenefitsMapClicked(object sender, EventArgs args)
		{
			await this.Navigation.PushAsync(new BenefitsAndDiscountsMapPage());

		}
	}
}

