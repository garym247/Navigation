using System.Windows.Input;
using Navigation.Commands;
using Navigation.Stores;

namespace Navigation.ViewModels
{
    public class DeviceListViewModel : ViewModelBase
    {
        public ICommand NavigateToDeviceViewCommand { get; }

        public DeviceListViewModel(NavigationStore navigationStore)
        {
            NavigateToDeviceViewCommand = new NavigateToDeviceViewCommand(navigationStore);
        }
    }
}
