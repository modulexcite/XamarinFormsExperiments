using Xamarin.Forms;
using System.Threading.Tasks;

namespace XamarinFormsExperiments
{
    public class CountryListViewModel : ViewModelBase
    {
        private string[] _countries;
        public string[] Countries 
        { 
            get { return _countries; }
            set { _countries = value; NotifyPropertyChanged(); }
        }

        public CountryListViewModel(INavigation navigation) : base(navigation)
        {
        }

        public override Task InitializeAsync(object parameter)
        {
            Countries = new []
            {
                "Deutschland",
                "Österreich",
                "Schweiz"
            };

            return Task.FromResult(0);
        }

        public async Task OpenCountry(string country)
        {
            await ShowViewModelAsync<CountryDetailViewModel>(country);
        }
    }
}

