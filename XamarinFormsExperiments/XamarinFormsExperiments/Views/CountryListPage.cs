using Xamarin.Forms;

namespace XamarinFormsExperiments
{
    public class CountryListPage : PageBase
    {
        public CountryListPage()
        {
            Title = "Länder";

            var countryList = new ListView();
            countryList.SetBinding<CountryListViewModel>(ListView.ItemsSourceProperty, x => x.Countries);

            countryList.ItemSelected += async (sender, e) => 
            {
                var viewModel = (CountryListViewModel)BindingContext;
                await viewModel.OpenCountry(e.SelectedItem.ToString());
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


