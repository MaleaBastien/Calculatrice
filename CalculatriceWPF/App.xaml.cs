using CalculatriceWPF.Services;
using CalculatriceWPF.Utilities;
using CalculatriceWPF.ViewModel;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CalculatriceWPF
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ServiceProvider _serviceProvider;

        public App()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddSingleton<MainWindow>(provider => new MainWindow
            {
                DataContext = provider.GetRequiredService<MainWindowViewModel>()
            });

            services.AddSingleton<MainWindowViewModel>();
            services.AddSingleton<CalculatriceViewModel>();
            services.AddSingleton<MorpionViewModel>();
            services.AddSingleton<INavigationService, NavigationService>();

            services.AddSingleton((Func<IServiceProvider, Func<Type, Utilities.ViewModel>>)(serviceProvider => viewModelType => (Utilities.ViewModel)serviceProvider.GetRequiredService(viewModelType)));

            _serviceProvider = services.BuildServiceProvider();
        }


        protected override void OnStartup(StartupEventArgs e)
        {
            var mainWindow = _serviceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
            base.OnStartup(e);
        }

    }
}
