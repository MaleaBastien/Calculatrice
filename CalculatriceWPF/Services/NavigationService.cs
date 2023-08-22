using CalculatriceWPF.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatriceWPF.Services
{
    public class NavigationService : ObservableObject, INavigationService
    {
        private Utilities.ViewModel _currentView;
        private Func<Type, Utilities.ViewModel> _viewModelFactory;

        public Utilities.ViewModel CurrentView
        {
            get => _currentView;
            private set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public NavigationService(Func<Type, Utilities.ViewModel> viewModelFactory)
        {
            _viewModelFactory = viewModelFactory;
        }

        public void NavigateTo<TViewModel>() where TViewModel : Utilities.ViewModel
        {
            Utilities.ViewModel viewModel = _viewModelFactory.Invoke(typeof(TViewModel));
            CurrentView = viewModel;
        }
    }
}
