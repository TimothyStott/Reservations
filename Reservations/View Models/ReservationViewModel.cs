using Reservations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations.View_Models
{
    public class ReservationViewModel : ViewModelBase
    {

        private readonly Reservation _reservation;
        public string Username => _reservation.Username;
        public  string RoomID => _reservation.RoomID?.ToString();
        public DateTime StartTime => _reservation.StartTime;
        public DateTime EndTime => _reservation.EndTime;

        public ReservationViewModel(Reservation reservation)
        {
            _reservation = reservation;
        }
    }
}
