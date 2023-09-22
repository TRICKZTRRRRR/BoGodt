using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodt.Model
{
    internal class Payment : Worker
    {
        View.View view = new View.View();

        #region Variables
        protected int _workerPayment {  get; set; }
        #endregion

        public Payment(string workerFirstName, string workerLastName, string workerType, int workerPayment) : base(workerFirstName, workerLastName, workerType)
        {
            _workerPayment = workerPayment;
        }

        public new void PrintInfo()
        {
            base.PrintInfo();
            view.WorkerPaymentGUI(_workerPayment);
        }
    }
}
