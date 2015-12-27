using Xamarin.Forms;

namespace XamarinFormsExperiments
{
    public class CountryDetailPage : PageBase
    {
        public CountryDetailPage()
        {
            this.SetBinding<CountryDetailViewModel>(Page.TitleProperty, x => x.Country);

            var label = new Label();
            label.SetBinding<CountryDetailViewModel>(Label.TextProperty, x => x.Country);

            Content = new StackLayout
            { 
                Children =
                {
                    label
                }
            };
        }
    }
}


