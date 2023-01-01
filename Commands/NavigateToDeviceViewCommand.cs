using Navigation.Stores;
using Navigation.ViewModels;

namespace Navigation.Commands
{
    public class NavigateToDeviceViewCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;

        public NavigateToDeviceViewCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new DeviceViewModel(_navigationStore);
        }
    }
}