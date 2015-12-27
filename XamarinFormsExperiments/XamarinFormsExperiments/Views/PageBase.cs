using Xamarin.Forms;

namespace XamarinFormsExperiments
{
    public abstract class PageBase : ContentPage, IView
    {
        public void SetViewModel(IViewModel viewModel)
        {
            BindingContext = viewModel;
        }
    }
}

