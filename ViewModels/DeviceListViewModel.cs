using System.Windows.Input;
using Navigation.Commands;
using Navigation.Stores;
using Navigation.Services;

namespace Navigation.ViewModels
{
    public class DeviceListViewModel : ViewModelBase
    {
        public ICommand NavigateToDeviceViewCommand { get; }

        public DeviceListViewModel(NavigationStore navigationStore)
        {
            //
            // Use a Create Command Delegate instead??
            //
            NavigateToDeviceViewCommand = new NavigateCommand<DeviceViewModel>(
                new NavigationService<DeviceViewModel>(
                    navigationStore,
                    () => new DeviceViewModel(navigationStore)));
        }
    }
}
