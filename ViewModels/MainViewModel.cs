namespace Navigation.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            CurrentViewModel = new DeviceListViewModel();

            //
            // To make the DeviceView the initial view change the CurrentViewMoel
            // to DeviceViewModel, i.e. 
            //
            // CurrentViewModel = new DeviceViewModel();
            //
        }

        public ViewModelBase CurrentViewModel { get; set; }
    }
}
