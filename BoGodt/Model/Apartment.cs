using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodt.Model
{
    internal class Apartment
    {
        protected string floor;
        protected string door;
        protected string window;
        protected string kitchen;

        public string Floor { get; set; }
        public string Door { get; set; }
        public string Window { get; set; }
        public string Kitchen { get; set;}
    }
}
