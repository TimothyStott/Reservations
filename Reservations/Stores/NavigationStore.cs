using Reservations.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations.Stores
{
    public class NavigationStore
    {
        public ViewModelBase _currentViewModel;

        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;

            set
            {
                _currentViewModel = value;
                OnCurentViewModelChanged();
            }
        }

        public event Action CurrentviewModelChange;

        private void OnCurentViewModelChanged()
        {
            CurrentviewModelChange?.Invoke();
        }


    }
}
