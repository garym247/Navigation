using System;
using Navigation.Stores;
using Navigation.ViewModels;

namespace Navigation.Services
{
    public class NavigationService<TCreateViewModel>
        where TCreateViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        private readonly Func<TCreateViewModel> _createViewModel;

        public NavigationService(NavigationStore navigationStore, Func<TCreateViewModel> createViewModel)
        {
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;
        }

        public void Navigate()
        {
            _navigationStore.CurrentViewModel = _createViewModel();
        }
    }
}