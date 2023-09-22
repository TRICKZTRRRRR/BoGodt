using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodt.Model
{
    internal class Requirement
    {
        View.View view = new View.View();

        #region Variables
        protected bool newFloor;
        protected bool newKitchen;
        protected bool renovatedBath;
        protected bool newFrontDoor;
        protected bool hasBackDoor;
        protected bool hasRepos;
        protected bool hasOtherFireEscpaeWays;
        protected bool has1BayWindow;
        protected bool has2BayWindow;
        protected bool has3BayWindow;
        #endregion

        public bool NewFloor {  get; set; }
        public bool NewKitchen {  get; set; }
        public bool RenovatedBath { get; set; }
        public bool NewFrontDoor { get; set; }
        public bool HasBackDoor { get; set; }
        public bool HasRepos { get; set; }
        public bool HasOtherFireEscpaeWays { get; set; }
        public bool Has1BayWindow {  get; set; }
        public bool Has2BayWindow {  get; set; }
        public bool Has3BayWindow {  get; set; }

        public Requirement(bool newFloor, bool newKitchen, bool renovatedBath, bool newFrontDoor, bool hasBackDoor, bool hasRepos, bool hasOtherFireEscpaeWays, bool has1BayWindow, bool has2BayWindow, bool has3BayWindow)
       {
            NewFloor = newFloor;
            NewKitchen = newKitchen;
            RenovatedBath = renovatedBath;
            NewFrontDoor = newFrontDoor;
            HasBackDoor = hasBackDoor;
            HasRepos = hasRepos;
            HasOtherFireEscpaeWays = hasOtherFireEscpaeWays;
            Has1BayWindow = has1BayWindow;
            Has2BayWindow = has2BayWindow;
            Has3BayWindow = has3BayWindow;
        } 

        public void PrintInfoReq()
        {
            view.Requirements();
        }
    }
}
