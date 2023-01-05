using System;
using Navigation.Stores;
using Navigation.ViewModels;

namespace Navigation.Commands
{
    public class NavigateCommand<TCreateViewModel> : CommandBase
        where TCreateViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        private readonly Func<TCreateViewModel> _createViewModel;

        public NavigateCommand(NavigationStore navigationStore, Func<TCreateViewModel> createViewModel)
        {
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;
        }

        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = _createViewModel();
        }

    }
}