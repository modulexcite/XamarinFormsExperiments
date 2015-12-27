using Xamarin.Forms;
using System.Threading.Tasks;

namespace XamarinFormsExperiments
{
    public class CountryListViewModel : ViewModelBase
    {
        public CountryListViewModel(INavigation navigation) : base(navigation)
        {
        }

        public async Task OpenCountry(string country)
        {
            await ShowViewModelAsync<CountryDetailViewModel>(country);
        }
    }
}

