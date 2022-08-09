using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows;
using Reservations.Models;
using Reservations.View_Models;
using Reservations.Exceptions;
using System.ComponentModel;

namespace Reservations.Commands
{
    internal class MakeReservationCommand : CommandBase
    {
        private readonly MakeReservationViewModel _makeReservationViewModel;
        private readonly Hotel _hotel;

        public MakeReservationCommand(MakeReservationViewModel makeReservationViewModel, Hotel hotel)
        {
            _makeReservationViewModel = makeReservationViewModel;
            _hotel = hotel;

            _makeReservationViewModel.PropertyChanged += OnViewModelPropertyChange;
        }



        public override bool CanExecute(object? parameter)
        {
            return !string.IsNullOrEmpty(_makeReservationViewModel.Username) && 
                _makeReservationViewModel.FloorNumber >0 && 
                _makeReservationViewModel.RoomNumber >0 &&
                base.CanExecute(parameter);
        }

        public override void Execute(object? parameter)
        {
            Reservation reservation = new Reservation(_makeReservationViewModel.Username.ToString(),
                new RoomID(_makeReservationViewModel.FloorNumber, _makeReservationViewModel.RoomNumber),
               _makeReservationViewModel.StartDate, _makeReservationViewModel.EndDate); ;



            try
            {
                _hotel.MakeReservation(reservation);
                MessageBox.Show("Successly reserved room.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            catch (ReservationConflictException ex)
            {
                MessageBox.Show("This room is already taken.","Error",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }


        private void OnViewModelPropertyChange(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(MakeReservationViewModel.Username) ||
                e.PropertyName == nameof(MakeReservationViewModel.FloorNumber) ||
                e.PropertyName == nameof(MakeReservationViewModel.RoomNumber))
            {
                OnCanExecutedChanged();
            }


        }
    }
}
