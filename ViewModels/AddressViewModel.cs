using Navigation.Commands;
using Navigation.Stores;
using System.Windows.Input;

namespace Navigation.ViewModels
{
    public class AddressViewModel : ViewModelBase
    {
        private NavigationStore _navigationStore;
        public ICommand NavigateAddressListViewCommand { get; }

        public AddressViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            NavigateAddressListViewCommand = new NavigateAddressListViewCommand(_navigationStore);
        }
    }
}
