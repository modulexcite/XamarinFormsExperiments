using System;

using Xamarin.Forms;
using XamarinFormsExperiments.ViewModels;
using XamarinFormsExperiments.Pages;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinFormsExperiments
{
    public class App : Application
    {
        public App()
        {
            // All that manual initialization stuff should be done automatically
            var viewModel = new CountryListViewModel();
            viewModel.Initialize(null);

            var list = new CountryListPage();
            list.SetViewModel(viewModel);

            MainPage = new NavigationPage(list);

            // Workaround
            ViewModelBase.Presenter = new FormsPresenter(Current.MainPage.Navigation);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

