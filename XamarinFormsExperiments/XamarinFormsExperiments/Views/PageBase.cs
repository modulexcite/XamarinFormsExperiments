using Xamarin.Forms;
using System.Linq.Expressions;
using System;

namespace XamarinFormsExperiments
{
    public abstract class PageBase<TViewModel> : ContentPage, IView
        where TViewModel : IViewModel
    {
        protected TViewModel ViewModel
        {
            get { return (TViewModel)BindingContext; }
        }

        protected void BindToViewModel(BindableObject self, BindableProperty targetProperty, 
            Expression<Func<TViewModel, object>> sourceProperty, BindingMode mode = BindingMode.Default, 
            IValueConverter converter = null, string stringFormat = null)
        {
            self.SetBinding(targetProperty, sourceProperty, mode, converter, stringFormat);
        }

        public void SetViewModel(IViewModel viewModel)
        {
            BindingContext = viewModel;
        }
    }
}

