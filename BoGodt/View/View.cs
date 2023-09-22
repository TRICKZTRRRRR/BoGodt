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

        public void Line()
        {
            Console.WriteLine("--------------------------------------------------");
        }

        public void ReadProgram()
        {
            Console.ReadLine();
        }

        public void WorkerOutputGUI(string workerFirstName, string workerLastName, string workerType)
        {
            Console.WriteLine($"\nName: {workerFirstName} {workerLastName}\n" +
                $"Work: {workerType}");
        }

        public void WorkerPaymentGUI(int workerPayment)
        {
            Console.WriteLine($"Payment: {workerPayment}\n");
        }
        #endregion
    }
}
