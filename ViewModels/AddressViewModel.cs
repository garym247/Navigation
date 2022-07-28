using System.Windows.Input;
using Navigation.Commands;
using Navigation.Stores;
namespace Navigation.ViewModels
{
    public class AddressViewModel : ViewModelBase
    {
        private NavigationStore _navigationStore;
        public ICommand NavigateAddressListViewCommand { get; }

        public AddressViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            NavigateAddressListViewCommand = new NavigateCommand(_navigationStore, () => new AddressListViewModel(_navigationStore) );
        }
    }
}
