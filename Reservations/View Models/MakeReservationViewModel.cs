using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Reservations.View_Models
{
    public class MakeReservationViewModel: ViewModelBase
    {
        private string _username;
        public string Username
        {
            get { return _username; }

            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        private int _roomNumber;
        public int RoomNumber
        {
            get { return _roomNumber; }

            set
            {
                _floorNumber = value;
                OnPropertyChanged(nameof(RoomNumber));  
            }
        }

        private int _floorNumber;
        public int FloorNumber
        {
            get { return _roomNumber; }

            set
            {
                _roomNumber = value;
                OnPropertyChanged(nameof(FloorNumber));
            }
        }


        private DateTime _startDate;
        public DateTime StartDate
        {
            get { return _startDate; }

            set
            {
                _startDate = value;
                OnPropertyChanged(nameof(StartDate));
            }
        }


        private DateTime _endDate;
        public DateTime EndDate
        {
            get { return _endDate; }

            set
            {
                _endDate = value;
                OnPropertyChanged(nameof(EndDate));
            }
        }

        public ICommand Submitcommand { get; }

        public ICommand CancelCommand { get; }


        public MakeReservationViewModel()
        {

        }


    }
}
