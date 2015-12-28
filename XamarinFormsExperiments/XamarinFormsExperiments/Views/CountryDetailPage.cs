using Xamarin.Forms;

namespace XamarinFormsExperiments
{
    public class CountryDetailPage : PageBase<CountryDetailViewModel>
    {
        public CountryDetailPage()
        {
            BindToViewModel(this, Page.TitleProperty, x => x.Country);

            var label = new Label();
            BindToViewModel(label, Label.TextProperty, x => x.Country);

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


