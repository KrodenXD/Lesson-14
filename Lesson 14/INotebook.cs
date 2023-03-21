using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14
{
    interface INotebook
    {
        public string Brand { get; set; }
        public string SubBrand { get; set; }
        public double Weight { get; set; }
        public byte Ram { get; set; }

        int count { get; set; }

        public void FirstAcceleration();
        public void SecondAcceleration(int t)
        {
            Console.WriteLine(t);
        }
    }
}
