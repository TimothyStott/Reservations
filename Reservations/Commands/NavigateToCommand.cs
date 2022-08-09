using Reservations.Stores;
using Reservations.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations.Commands
{
    internal class NavigateToCommand: CommandBase
    {
        private readonly NavigationStore _navigationStore;

        public NavigateToCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object? parameter)
        {
            _navigationStore.CurrentViewModel = new MakeReservationViewModel(new Models.Hotel("Test") );
        }
    }
}
