using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Program executer
            Controller.Controller controller = new Controller.Controller();
            controller.MainController();
            #endregion
        }
    }
}
