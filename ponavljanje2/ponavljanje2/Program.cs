using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponavljanje2
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasaD objekt = new KlasaD();

            int a = 50;
            bool b = true;

            int minus = objekt.Suprotno(a);

            bool trueilifalse = objekt.Suprotno(b);


            Console.ReadKey();
        }
    }
}
