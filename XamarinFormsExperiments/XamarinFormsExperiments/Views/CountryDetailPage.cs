using System;

using Xamarin.Forms;

namespace XamarinFormsExperiments
{
    public class CountryDetailPage : ContentPage
    {
        public CountryDetailPage(string land)
        {
            Title = land;

            Content = new StackLayout
            { 
                Children =
                {
                    new Label { Text = land }
                }
            };
        }
    }
}


