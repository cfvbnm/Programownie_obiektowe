using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car auto = new Car(20, "Jakas marka");
            Console.WriteLine(auto.pojemnoscSilnika);
            Console.WriteLine(auto.marka);

            Console.ReadLine();

        }
    }
}
