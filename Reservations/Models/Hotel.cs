using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations.Models
{
    public class Hotel
    {
        private readonly ReservationBook _reservationBook;

        public string Name { get;  }    

        public Hotel(string name)
        {
            Name = name;
            _reservationBook = new ReservationBook();
        }


        /// <summary>
        /// Get all reservations.
        /// </summary>
        /// <returns>All reservations in the hotel reservation book.</returns>
        public IEnumerable<Reservation> GetAllReservations()
        {
            return _reservationBook.GetAllReservatins();
        }


        /// <summary>
        /// Make a reservation.
        /// </summary>
        /// <param name="reservation">The incoming reservation</param>
        /// <exception cref="InvalidReservationTimeRangeException">Thrown if reservation start time is after end time.</exception>
        /// <exception cref="ReservationConflictException">Thrown if incoming reservation conflicts with existing reservation.</exception>
        public void MakeReservation(Reservation reservation)
        {
            _reservationBook.AddReservation(reservation);
        }

    }
}
