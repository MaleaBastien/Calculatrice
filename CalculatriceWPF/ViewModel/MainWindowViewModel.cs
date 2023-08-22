using CalculatriceWPF.Services;
using CalculatriceWPF.Utilities;

namespace CalculatriceWPF.ViewModel
{
    public class MainWindowViewModel : Utilities.ViewModel
    {
        private INavigationService _navigationService;
        public INavigationService Navigation {
            get => _navigationService;
            set
            {
                _navigationService = value;
                OnPropertyChanged();
            }        
        }

        public RelayCommand NavigationCalculatriceCommand { get; set; }

        public RelayCommand NavigationMorpionCommand {  get; set; }

        public MainWindowViewModel(INavigationService navService)
        {
            Navigation = navService;
            NavigationCalculatriceCommand = new RelayCommand(o => { Navigation.NavigateTo<CalculatriceViewModel>(); }, o => true);
            NavigationMorpionCommand = new RelayCommand(o => { Navigation.NavigateTo<MorpionViewModel>(); }, o => true);
        }

    }
}
