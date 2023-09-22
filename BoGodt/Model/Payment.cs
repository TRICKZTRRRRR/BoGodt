using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodt.Model
{
    internal class Payment : Worker 
    {
        #region Variables
        protected int _laborerPayment {  get; set; }
        protected int _apprenticePayment { get; set; }
        protected int _journeymanPayment { get; set; }
        #endregion

        public Payment(string workerFirstName, string workerLastName, string workerType, int laborerPayment, int apprenticePayment, int journeymentPayment) : base(workerFirstName, workerLastName, workerType)
        {

        }
    }
}
