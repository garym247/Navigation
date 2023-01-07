using System.Windows.Input;
using Navigation.Commands;
using Navigation.Services;
using Navigation.Stores;

namespace Navigation.ViewModels
{
    public class DeviceViewModel : ViewModelBase
    {
        public ICommand NavigateToDeviceListViewCommand { get; }

        public DeviceViewModel(NavigationStore navigationStore)
        {            
            //
            // Use a Create Command Delegate instead??
            //
            NavigateToDeviceListViewCommand = new NavigateCommand<DeviceListViewModel>(
                new NavigationService<DeviceListViewModel>(
                    navigationStore, 
                    () => new DeviceListViewModel(navigationStore)));

        }
    }
}
