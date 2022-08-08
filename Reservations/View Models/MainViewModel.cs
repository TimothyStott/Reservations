using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reservations.Views;
using Reservations.Models;
using Reservations.View_Models;

namespace Reservations.View_Models
{
    public class MainViewModel : ViewModelBase
    {
        public ViewModelBase CurrentViewModel { get; }

        public MainViewModel()
        {
            CurrentViewModel = new MakeReservationViewModel();
        }
    }
}
