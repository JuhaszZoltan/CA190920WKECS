using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA190920WKECS
{
    class Program
    {
        static void Main(string[] args)
        {
            var farkasok = new List<Farkas>()
            {
                new Farkas("HosszúFaSzú", true, 5),
                new Farkas("Hagyma", false, 4),
                new Farkas("FarkasÚr", true, 4),
                new Farkas("Feri", true, 3),
                new Farkas("Fofo", true, 6)
            };
            Console.WriteLine("Összes farkas neve: ");
            foreach (var f  in farkasok)
            {
                Console.WriteLine(f.Nev);
            }
            Console.ReadKey();
        }
    }
}
