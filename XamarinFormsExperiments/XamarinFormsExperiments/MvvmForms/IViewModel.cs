using System.ComponentModel;

namespace XamarinFormsExperiments
{
    public interface IViewModel : INotifyPropertyChanged
    {
        void Initialize(object parameter);
    }
}

