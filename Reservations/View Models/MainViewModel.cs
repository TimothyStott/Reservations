using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservations.Views;
using Reservations.Models;
using Reservations.View_Models;
using Reservations.Stores;

namespace Reservations.View_Models
{
    public class MainViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        
        public MainViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;


            _navigationStore.CurrentviewModelChange += OnCurrentViewModelChanged;
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel)); 
        }

        public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;
    }
}
