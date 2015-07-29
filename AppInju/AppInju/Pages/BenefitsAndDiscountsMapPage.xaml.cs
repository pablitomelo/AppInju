using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace AppInju
{
	public partial class BenefitsAndDiscountsMapPage : ContentPage
	{
		public BenefitsAndDiscountsMapPage ()
		{
			InitializeComponent ();

			MyMap.MoveToRegion(
				MapSpan.FromCenterAndRadius(
					new Position(37,-122), Distance.FromMiles(1)));
		}
	}
}

