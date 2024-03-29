﻿namespace XamarinFormsExperiments.ViewModels
{
    public class CountryDetailViewModel : ViewModelBase
    {
        private string _country;
        public string Country 
        { 
            get { return _country; }
            set { _country = value; NotifyPropertyChanged(); }
        }

        public override void Initialize(object parameter)
        {
            Country = parameter.ToString();
        }
    }
}

