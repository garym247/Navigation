using System;
using System.Windows.Input;
using Navigation.Stores;
using Navigation.ViewModels;

namespace Navigation.Commands
{
    public class NavigateCommand : ICommand
    {
        private NavigationStore _navigationStore;
        private Func<ViewModelBase> _createViewModelFunc;
        
        public NavigateCommand(NavigationStore navigationStore, Func<ViewModelBase> createViewModelFunc)
        {
            _navigationStore = navigationStore;
            _createViewModelFunc = createViewModelFunc;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = _createViewModelFunc();
        }
    }
}