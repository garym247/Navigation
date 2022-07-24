using Navigation.Stores;
using Navigation.ViewModels;
using System;
using System.Windows.Input;

namespace Navigation.Commands
{
    public class NavigateAddressViewCommand : ICommand
    {
        private NavigationStore _navigationStore;

        public NavigateAddressViewCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new AddressViewModel(_navigationStore);
        }
    }
}
