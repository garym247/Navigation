using Navigation.Stores;
using Navigation.ViewModels;

namespace Navigation.Commands
{
    public class NavigateToDeviceListViewCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;

        public NavigateToDeviceListViewCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new DeviceListViewModel(_navigationStore);
        }
    }
}