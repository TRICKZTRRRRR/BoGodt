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
        //public void MainController()
        //{
        //    Payment worker1 = new Payment("Torben", "Hansen", "Apprentice", 10000);
        //    Payment worker2 = new Payment("Torben", "Hansen", "Apprentice", 10000);

        //    view.WorkerGUI();
        //    view.Line();
        //    worker1.PrintInfo();
        //    worker2.PrintInfo();
        //    view.Line();

        //    view.ReadProgram();
        //}

        public void MainController()
        {
        }

        public void InsertData()
        {
            Model.List allWorkers = new Model.List();

            // Data of the workers
            Model.Worker worker1 = new Model.Worker("Torben", "Hansen", "Apprentice", 10000);

            // Add a worker to the list
            allWorkers.AddWorker(worker1);
        }
        #endregion
    }
}
