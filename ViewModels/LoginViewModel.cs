using System.Windows.Input;
using Navigation.Commands;
using Navigation.Stores;

namespace Navigation.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        public ICommand NavigateToDeviceListViewCommand { get; }

        public LoginViewModel(NavigationStore navigationStore)
        {
            NavigateToDeviceListViewCommand = new NavigateCommand<DeviceListViewModel>(
                navigationStore, () => new DeviceListViewModel(navigationStore));
        }
    }
}
