using CalculatriceWPF.Enumeration;
using CalculatriceWPF.Utilities;
using System;
using System.Windows.Controls;
using System.Windows.Input;

namespace CalculatriceWPF.ViewModel
{
    public class MorpionViewModel : Utilities.ViewModel
    {
        #region Propriete
        private MorpionDifficultiesEnum currentDifficulty;

        public MorpionDifficultiesEnum CurrentDifficulty
        {
            get => currentDifficulty;
            set
            {
                currentDifficulty = value;
                OnPropertyChanged(nameof(CurrentDifficulty));
            }
        }

        #region Command

        public ICommand PlayCommand { get; }
        #endregion

        public MorpionDifficultiesEnum[] Difficulties => (MorpionDifficultiesEnum[])Enum.GetValues(typeof(MorpionDifficultiesEnum));

        #endregion

        public MorpionViewModel() 
        {
            CurrentDifficulty = MorpionDifficultiesEnum.FACILE;
            PlayCommand = new RelayCommand(PlayedMethod, CanPlay);
        }

        private bool CanPlay(object arg)
        {
            return true;
        }

        private void PlayedMethod(object obj)
        {

        }
    }
}