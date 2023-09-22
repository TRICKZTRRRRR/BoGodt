using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodt.View
{
    internal class View
    {
        #region View

        public void WorkerGUI()
        {
            Console.WriteLine("Workers");
        }

        public void ApartmentGUI()
        {
            Console.WriteLine("Apartments");
        }

        public void Line()
        {
            Console.WriteLine("--------------------------------------------------\n");
        }

        public void ReadProgram()
        {
            Console.ReadLine();
        }

        public void WorkerOutputGUI(string workerFirstName, string workerLastName, string workerType)
        {
            Console.WriteLine($"Name: {workerFirstName} {workerLastName}\n" +
                $"Work: {workerType}");
        }

        public void WorkerPaymentGUI(int workerPayment)
        {
            Console.WriteLine($"Payment: {workerPayment}\n");
        }

        public void ApartmentOneGUI(int totalCost)
        {
            Console.WriteLine($"Total cost for a apartment with 1 room: {totalCost}");
        }

        public void Requirements(bool newFloor, bool newKitchen, bool renovatedBath, bool newFrontDoor, bool hasBackDoor, bool hasRepos, bool hasOtherFireEscapeWays, bool has1BayWindow, bool has2BayWindow, bool has3BayWindow)
        {
            Console.WriteLine($"Requirement: {newFloor}, {newKitchen}, {renovatedBath}, {newFrontDoor}, {hasBackDoor}, {hasRepos}, {hasOtherFireEscapeWays}, {has1BayWindow}, {has2BayWindow}, {has3BayWindow}");
        }

        public void ApartmentTwoGUI(int apartmentNumber)
        {
            Console.WriteLine($"Apartment number {apartmentNumber} with 2 rooms");
        }

        public void ApartmentThreeGUI(int apartmentNumber)
        {
            Console.WriteLine($"Apartment number {apartmentNumber} with 3 rooms");
        }

        public void ApartmentFourGUI(int apartmentNumber)
        {
            Console.WriteLine($"Apartment number {apartmentNumber} with 4 rooms");
        }

        public void ApartmentFiveGUI(int apartmentNumber)
        {
            Console.WriteLine($"Apartment number {apartmentNumber} with 5 rooms");
        }








        #endregion
    }
}
