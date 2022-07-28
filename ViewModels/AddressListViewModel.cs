using Navigation.Commands;
using Navigation.Stores;
using System.Windows.Input;

namespace Navigation.ViewModels
{
    public class AddressListViewModel : ViewModelBase
    {
        private NavigationStore _navigationStore;

        public ICommand NavigateAddressViewCommand { get; }

        public AddressListViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            NavigateAddressViewCommand = new NavigateCommand(_navigationStore, () => new AddressViewModel(_navigationStore) );
        }
    }
}
