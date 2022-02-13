using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndStuff
{
    abstract class Gyvunas
    {
        public Gyvunas()
        {

        }
        public abstract void Kalbeti();
        public void Miegoti()
        {
            Console.WriteLine("Miegu!");
        }
    }
}
