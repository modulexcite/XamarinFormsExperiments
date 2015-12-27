using System;

using Xamarin.Forms;

namespace XamarinFormsExperiments
{
    public class App : Application
    {
        public App()
        {
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

