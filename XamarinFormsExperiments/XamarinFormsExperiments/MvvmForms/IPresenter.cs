using System.Threading.Tasks;

namespace XamarinFormsExperiments
{
    public interface IPresenter
    {
        Task ShowViewModelAsync<TViewModel>(object parameter) 
            where TViewModel : IViewModel;
    }
}

