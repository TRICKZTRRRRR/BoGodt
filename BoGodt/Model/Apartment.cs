using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodt.Model
{
    internal class Apartment
    {
        protected bool _furnished;
        protected bool _sharingFriendly;
        protected bool _petsAllowed;
        protected bool _elevator;
        protected bool _seniorFriendly;
        protected bool _onlyForStudents;
        protected bool _balconyOrTerrace;
        protected bool _parking;
        protected bool _dishwasher;
        protected bool _washingMaching;
        protected bool _chargingStand;
        protected bool _dryer;
        protected bool _energyLabel;

        public bool Furnished { get { return _furnished; } set { _furnished = value; } }
        public bool SharingFriendly { get {  return _sharingFriendly; } set { _sharingFriendly = value; } }
        public bool PetsAllowed { get { return _petsAllowed; } set { _petsAllowed = value; } }
        public bool Elevator { get { return _elevator; } set { _elevator = value; } }
        public bool SeniorFriendly { get { return _seniorFriendly; } set { _seniorFriendly = value; } }
        public bool OnlyForStudents {  get { return _onlyForStudents; } set { _onlyForStudents = value;} }
        public bool BalconyOrTerrace { get {  return _balconyOrTerrace;} set { _balconyOrTerrace = value; } }
        public bool Parking { get { return _parking; } set { _parking = value; } }
        public bool Dishwasher { get { return _dishwasher;} set { _dishwasher = value;} }
        public bool WashingMachine { get { return _washingMaching; } set { _washingMaching = value; } }
        public bool ChargingStand {  get { return _chargingStand; } set { _chargingStand = value; } }
        public bool Dryer { get { return _dryer; } set { _dryer = value; } }
        public bool EnergyLabel { get { return _energyLabel; } set { _energyLabel = value; } }
    }
}
