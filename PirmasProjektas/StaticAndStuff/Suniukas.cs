using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndStuff
{
    class Suniukas : Gyvunas, IPrintData
    {
        public Suniukas()
        {

        }
        public override void Kalbeti()
        {
            Console.WriteLine("Au au!");
        }

        public void PrintData()
        {
            // implementacijos kodas
        }
    }
}
