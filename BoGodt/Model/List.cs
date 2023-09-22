using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodt.Model
{
    internal class List
    {
       List<Worker> workers { get; set; } = new List<Worker>(); // Creates a list of workers
        List<Worker> allWorkers { get; set; } = new List<Worker>();

        public void AddWorker(Worker worker)
        {
            workers.Add(worker);
            allWorkers.Add(worker);
        }
    }
}
