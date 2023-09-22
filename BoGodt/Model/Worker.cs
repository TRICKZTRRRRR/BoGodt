using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodt.Model
{
    internal class Worker
    {
        View.View view = new View.View();

        #region Variables
        protected string WorkerFirstName {  get; set; }
        protected string WorkerLastName { get; set; }
        protected string WorkerType { get; set; }
        #endregion


        public Worker(string workerFirstName, string workerLastName, string workerType)
        {
            WorkerFirstName = workerFirstName;
            WorkerLastName = workerLastName;
            WorkerType = workerType;
        }

        public void PrintInfo()
        {
            view.WorkerOutputGUI(WorkerFirstName, WorkerLastName, WorkerType);
        }
    }
}
