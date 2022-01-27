using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paveldimumas
{
    abstract class Figura
    {
        public string Pavadinimas { get; }

        public Figura(string pavadinimas)
        {
            Pavadinimas = pavadinimas;
        }

        public void Metodas()
        {
            Console.WriteLine("EIII METODAS!!");
        }
    }
}
