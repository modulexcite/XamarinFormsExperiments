using Xamarin.Forms;
using System.Threading.Tasks;

namespace XamarinFormsExperiments
{
    public class CountryDetailViewModel : ViewModelBase
    {
        private string _country;
        public string Country 
        { 
            get { return _country; }
            set { _country = value; NotifyPropertyChanged(); }
        }

        public CountryDetailViewModel(INavigation navigation) : base(navigation)
        {
        }

        public override Task InitializeAsync(object parameter)
        {
            // Just to demonstrate data-binding is working.
            Task.Run(async () =>
            {
                await Task.Delay(2000);
                Country = parameter.ToString();
            });

            return Task.FromResult(0);
        }
    }
}

