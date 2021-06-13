using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponavljanje2
{
    class KlasaD
    {
        public bool Suprotno(bool b)
        {
            b = !true;

            Console.WriteLine("Suprotno od true je: " + b);

            return b;
        }

        public int Suprotno(int a)
        {
            a = (-1) * a;

            Console.WriteLine("Broj suprotan od 50 je: " + a);

            return a;
        }
    }
}
