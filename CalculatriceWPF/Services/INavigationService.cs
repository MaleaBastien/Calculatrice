using CalculatriceWPF.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatriceWPF.Services
{
    public interface INavigationService
    {
        Utilities.ViewModel CurrentView { get; }
        void NavigateTo<T>() where T : Utilities.ViewModel;
    }
}
