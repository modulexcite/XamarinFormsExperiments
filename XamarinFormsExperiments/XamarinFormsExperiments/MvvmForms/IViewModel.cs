using System.Threading.Tasks;

namespace XamarinFormsExperiments
{
    public interface IViewModel
    {
        Task InitializeAsync(object parameter);
    }
}

