using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14
{
    class EriksNotebook : INotebook
    {
        private string brand;
        public string Brand { get { return brand; } set { brand = "100"; } }
        public string SubBrand { get; set; }
        public double Weight { get; set; }
        public byte Ram { get; set; }
        public int count { get; set; }

        public void FirstAcceleration()
        {
            Console.WriteLine("Brand " + brand);
            Console.WriteLine("EriksNotebook : INotebook++ FirstAcceleration");
        }
        void INotebook.SecondAcceleration(int t) { } //a way to call an method from interface,since there is no body it does nothing
    }
}
