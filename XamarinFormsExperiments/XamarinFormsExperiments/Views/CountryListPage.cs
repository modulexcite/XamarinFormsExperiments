using System;

using Xamarin.Forms;

namespace XamarinFormsExperiments
{
    public class CountryListPage : ContentPage
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

            countryList.ItemSelected += async (object sender, SelectedItemChangedEventArgs e) => 
            {
                var detailPage = new CountryDetailPage(e.SelectedItem.ToString());
                await Navigation.PushAsync(detailPage);
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


