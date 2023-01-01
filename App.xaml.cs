using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Navigation.ViewModels;
using Navigation.Stores;

namespace Navigation
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private NavigationStore _navigationStore;

        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore = new NavigationStore();
            _navigationStore.CurrentViewModel = new DeviceListViewModel(_navigationStore);

            //
            // To make the DeviceView the initial view change the navigation store
            // CurrentViewModel to DeviceViewModel, i.e. 
            //
            // _navigationStore.CurrentViewModel = new DeviceViewModel(_navigationStore);
            //

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };

            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
