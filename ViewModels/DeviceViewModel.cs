using System.Windows.Input;
using Navigation.Commands;
using Navigation.Stores;

namespace Navigation.ViewModels
{
    public class DeviceViewModel : ViewModelBase
    {
        public ICommand NavigateToDeviceListViewCommand { get; }

        public DeviceViewModel(NavigationStore navigationStore)
        {
            NavigateToDeviceListViewCommand = new NavigateCommand<DeviceListViewModel>(navigationStore, () => new DeviceListViewModel(navigationStore));
        }
    }
}
