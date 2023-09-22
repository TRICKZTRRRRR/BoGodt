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
        public void WorkerOutput(string workerFirstName, string workerLastName, string workerType)
        {
            Console.WriteLine($"Name: {workerFirstName} {workerLastName}\n" +
                $"Work: {workerType}");
        }
        #endregion
    }
}
