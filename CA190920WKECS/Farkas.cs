using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA190920WKECS
{
    class Farkas
    {
        public string Nev { get; set; }
        public bool Farok { get; set; }
        public int Lab { get; set; }
        public Farkas(string n, bool f, int l)
        {
            Nev = n;
            Farok = f;
            Lab = l;
        }
    }
}
