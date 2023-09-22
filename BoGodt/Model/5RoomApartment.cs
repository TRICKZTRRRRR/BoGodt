using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodt.Model
{
    internal class _5RoomApartment : Apartment
    {
        public _5RoomApartment(bool furnishes, bool sharingFriendly, bool petsAllowed, bool elevator, bool seniorFriendly, bool onlyForStudents, bool balconyOrTerrance, bool parking, bool dishwasher, bool washingMachine, bool chargingStand, bool dryer, char energyLabel)
    : base(furnishes, sharingFriendly, petsAllowed, elevator, seniorFriendly, onlyForStudents, balconyOrTerrance, parking, dishwasher, washingMachine, chargingStand, dryer, energyLabel)
        {

        }
    }
}
