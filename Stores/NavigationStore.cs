using Navigation.ViewModels;
using System;

namespace Navigation.Stores
{
    public class NavigationStore
    {
        public event Action CurrentViewModelChangedEvent;

        private ViewModelBase _currentViewModel;

        public ViewModelBase CurrentViewModel
        { 
            get
            {
                return _currentViewModel;
            }
            set
            {
                _currentViewModel = value;
                OnCurrentViewModelChanged();
            }
        }

        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChangedEvent?.Invoke();
        }
    }
}