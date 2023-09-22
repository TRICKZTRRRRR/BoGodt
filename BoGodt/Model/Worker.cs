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
        protected string _workerFirstName {  get; set; }
        protected string _workerLastName { get; set; }
        protected string _workerType { get; set; }
        #endregion

        public Worker(string workerFirstName, string workerLastName, string workerType)
        {
            _workerFirstName = workerFirstName;
            _workerLastName = workerLastName;
            _workerType = workerType;
        }

        public void WorkerData()
        {
            view.WorkerOutput(_workerFirstName, _workerLastName, _workerType);
        }
    }
}
