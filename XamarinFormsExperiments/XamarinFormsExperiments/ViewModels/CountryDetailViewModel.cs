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

        public override void Initialize(object parameter)
        {
            Country = parameter.ToString();
        }
    }
}

