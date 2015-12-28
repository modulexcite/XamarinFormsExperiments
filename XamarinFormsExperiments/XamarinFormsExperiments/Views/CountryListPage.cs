using Xamarin.Forms;

namespace XamarinFormsExperiments
{
    public class CountryListPage : PageBase<CountryListViewModel>
    {
        public CountryListPage()
        {
            Title = "Länder";

            var countryList = new ListView();
            BindToViewModel(countryList, ListView.ItemsSourceProperty, x => x.Countries);

            countryList.ItemSelected += async (sender, e) => 
                await ViewModel.OpenCountryAsync(e.SelectedItem.ToString());

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


