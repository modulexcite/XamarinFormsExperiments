using Xamarin.Forms;

namespace XamarinFormsExperiments
{
    public class PageBase : ContentPage, IView
    {
        public void SetViewModel(IViewModel viewModel)
        {
            BindingContext = viewModel;
        }
    }
}

