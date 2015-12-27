﻿using Xamarin.Forms;

namespace XamarinFormsExperiments
{
    public class CountryListPage : PageBase
    {
        public CountryListPage()
        {
            Title = "Länder";

            var countryList = new ListView();

            countryList.ItemsSource = new []
            {
                "Deutschland",
                "Österreich",
                "Schweiz"
            };

            countryList.ItemSelected += async (sender, e) => 
            {
                var viewModel = (CountryListViewModel)BindingContext;
                await viewModel.OpenCountry(e.SelectedItem.ToString());

//                var detailPage = new CountryDetailPage(e.SelectedItem.ToString());
//                await Navigation.PushAsync(detailPage);
            };

            Content = new StackLayout
            { 
                Children =
                {
                    countryList
                }
            };
        }
    }
}

