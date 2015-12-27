using Xamarin.Forms;
using System.Threading.Tasks;
using System;
using System.Reflection;
using System.Linq;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XamarinFormsExperiments
{
    public class ViewModelBase : IViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly INavigation _navigation;

        public ViewModelBase(INavigation navigation)
        {
            _navigation = navigation;
        }

        public virtual void Initialize(object parameter)
        {
            // Hook
        }

        protected void NotifyPropertyChanged([CallerMemberName]string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        protected async Task ShowViewModelAsync<TViewModel>(object parameter)
        {
            Type viewModelType = typeof(TViewModel);
            string pageName = viewModelType.Name.Replace("ViewModel", "Page");

            Type pageType = viewModelType.GetTypeInfo().Assembly.DefinedTypes
                .Select(t => t.AsType())
                .FirstOrDefault(t => t.Name == pageName);
            
            var page = Activator.CreateInstance(pageType) as Page;

            var viewModel = Activator.CreateInstance(viewModelType, page.Navigation) as IViewModel;
            viewModel.Initialize(parameter);

            ((IView)page).SetViewModel(viewModel);

            await _navigation.PushAsync(page, true);
        }
    }
}

