using System;
using Navigation.Services;
using Navigation.Stores;
using Navigation.ViewModels;

namespace Navigation.Commands
{
    public class NavigateCommand<TCreateViewModel> : CommandBase
        where TCreateViewModel : ViewModelBase
    {
        private readonly NavigationService<TCreateViewModel> _navigationService;
 
        public NavigateCommand(NavigationService<TCreateViewModel> navigationService)
        {
            _navigationService = navigationService;
        }

        public override void Execute(object parameter)
        {
            _navigationService.Navigate();
        }

    }
}