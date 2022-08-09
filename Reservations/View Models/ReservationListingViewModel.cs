using Reservations.Commands;
using Reservations.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Reservations.View_Models
{
    public class ReservationListingViewModel: ViewModelBase
    {

        private readonly ObservableCollection<ReservationViewModel> _reservations;

        public IEnumerable<ReservationViewModel> Reservations => _reservations;

        public ICommand MakeReservationCommand { get; }


        public ReservationListingViewModel()
        {
            _reservations = new ObservableCollection<ReservationViewModel>();

            MakeReservationCommand = new NavigateToCommand();


            _reservations.Add(new ReservationViewModel(new Models.Reservation("SingletonSean", new RoomID(1, 2), DateTime.Now, DateTime.Now)));
            _reservations.Add(new ReservationViewModel(new Models.Reservation("SingletonSean", new RoomID(1, 2), DateTime.Now, DateTime.Now)));
            _reservations.Add(new ReservationViewModel(new Models.Reservation("SingletonSean", new RoomID(1, 2), DateTime.Now, DateTime.Now)));
            _reservations.Add(new ReservationViewModel(new Models.Reservation("SingletonSean", new RoomID(1, 2), DateTime.Now, DateTime.Now)));
        }

    }


}
