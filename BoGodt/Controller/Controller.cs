using BoGodt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodt.Controller
{
    internal class Controller
    {
        View.View view = new View.View();

        #region Main Controler
        /// <summary>
        /// Sends input to Program.cs and the Main Controller of the program
        /// </summary>
        public void MainController()
        {
            view.WorkerGUI();
            view.Line();
            InsertData();
            view.Line();
            view.ApartmentGUI();
            Console.WriteLine("--------------------------------------------------\n");
            OneRoomApartment();
            view.ReadProgram();
        }
        #endregion

        #region Insert Data
        /// <summary>
        /// Inserts data
        /// </summary>
        public void InsertData()
        {
            int labrorPayment = 450 * 10;
            int apprenticePayment = 650 * 10;
            int journeymenyPayment = 1000 * 10;


            Payment worker1 = new Payment("Torben", "Hansen", "Laborer", labrorPayment);
            Payment worker2 = new Payment("Anders", "Kristensen", "Apprentice", apprenticePayment);
            Payment worker3 = new Payment("Morten", "Smith", "Journeymen", journeymenyPayment);

            worker1.PrintInfo();
            worker2.PrintInfo();
            worker3.PrintInfo();

            Requirement apartment1 = new Requirement(true, true, true, true, true, false, false, false, false, false);

            apartment1.PrintInfoReq();
        }
        #endregion

        /// <summary>
        /// Calculating the renovating price for the one room apartment
        /// </summary>
        public void OneRoomApartment() // 40 kvm
        {
            int totalCost = 0;

            // 1 Apartment
            int floor = 179 * 40; // Price for new floor
            int kitchen = 37899; // Price for the kitchen
            int bathWindow = 1897; // Price for the renvated bath
            int frontDoor = 6465; // Price for the front door
            int backDoor = 4879; // Price for the back door

            for (int apartmentNumber = 0; apartmentNumber < 369; apartmentNumber++)
            {
                int totalFloorCost = floor * apartmentNumber;
                int totalKitchenCost = kitchen * apartmentNumber;
                int totalBathWindowCost = bathWindow * apartmentNumber;
                int totalFrontDoorCost = frontDoor * apartmentNumber;
                int totalBackDoorCost = backDoor * apartmentNumber;

                totalCost = totalFloorCost + totalKitchenCost + totalBathWindowCost + totalFrontDoorCost + totalBackDoorCost;
            }

            view.ApartmentOneGUI(totalCost);
        }

        public void TwoRoomApartment() // 55 kvm
        {
            for (int apartmentNumber = 0; apartmentNumber < 236; apartmentNumber++)
            {
                view.ApartmentTwoGUI(apartmentNumber);
            }
        }

        public void ThreeRoomApartment() // 70 kvm
        {
            for (int apartmentNumber = 0; apartmentNumber < 168; apartmentNumber++)
            {
                view.ApartmentThreeGUI(apartmentNumber);
            }
        }

        public void FourRoomApartment() // 85 kvm
        {
            for (int apartmentNumber = 0; apartmentNumber < 98; apartmentNumber++)
            {
                view.ApartmentFourGUI(apartmentNumber);
            }
        }

        public void FiveRoomApartment() // 110 kvm
        {
            for (int apartmentNumber = 0; apartmentNumber < 48; apartmentNumber++)
            {
                view.ApartmentFiveGUI(apartmentNumber);
            }
        }
    }
}
