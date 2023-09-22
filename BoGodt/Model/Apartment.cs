using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BoGodt.Model
{
    abstract class Apartment
    {
        #region Variables
        protected bool Furnished {  get; set; }
        protected bool SharingFriendly { get; set; }
        protected bool PetsAllowed { get; set; }
        protected bool Elevator { get; set; }
        protected bool SeniorFriendly { get; set; }
        protected bool OnlyForStudents { get; set; }
        protected bool BalconyOrTerrace { get; set; }
        protected bool Parking { get; set; }
        protected bool Dishwasher { get; set; }
        protected bool WashingMaching { get; set; }
        protected bool ChargingStand { get; set; }
        protected bool Dryer { get; set; }
        protected char EnergyLabel { get; set; }
        #endregion

        public Apartment(bool furnishes, bool sharingFriendly, bool petsAllowed, bool elevator, bool seniorFriendly, bool onlyForStudents, bool balconyOrTerrance, bool parking, bool dishwasher, bool washingMachine, bool chargingStand, bool dryer, char energyLabel)
        {
            Furnished = furnishes;
            SharingFriendly = sharingFriendly;
            PetsAllowed = petsAllowed;
            Elevator = elevator;
            SeniorFriendly = seniorFriendly;
            OnlyForStudents = onlyForStudents;
            BalconyOrTerrace = balconyOrTerrance;
            Parking = parking;
            Dishwasher = dishwasher;
            WashingMaching = washingMachine;
            ChargingStand = chargingStand;
            Dryer = dryer;
            EnergyLabel = energyLabel;
        }
    }
}
