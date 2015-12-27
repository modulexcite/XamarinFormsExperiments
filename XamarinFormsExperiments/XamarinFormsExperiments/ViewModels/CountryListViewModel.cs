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

        public override void Initialize(object parameter)
        {
            Countries = new []
            {
                "Deutschland",
                "Österreich",
                "Schweiz"
            };
        }

        public async Task OpenCountryAsync(string country)
        {
            await ShowViewModelAsync<CountryDetailViewModel>(country);
        }
    }
}

