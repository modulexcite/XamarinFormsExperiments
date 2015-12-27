using System;

using Xamarin.Forms;

namespace XamarinFormsExperiments
{
    public class App : Application
    {
        public App()
        {
            var list = new CountryListPage();
            var viewModel = new CountryListViewModel(list.Navigation);
            list.SetViewModel(viewModel);

            MainPage = new NavigationPage(list);
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

