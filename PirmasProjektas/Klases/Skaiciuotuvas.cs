using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klases
{
    class Skaiciuotuvas
    {
        public int PirmasSkaicius;
        public int AntrasSkaicius;

        public Skaiciuotuvas(int pirmasSkaicius, int antrasSkaicius)
        {
            PirmasSkaicius = pirmasSkaicius;
            AntrasSkaicius = antrasSkaicius;
        }

        public void Suma()
        {
            Console.WriteLine($"{PirmasSkaicius} + {AntrasSkaicius} = {PirmasSkaicius + AntrasSkaicius}");
        }

        public void Skirtumas()
        {
            Console.WriteLine($"{PirmasSkaicius} - {AntrasSkaicius} = {PirmasSkaicius - AntrasSkaicius}");
        }

        public void Sandauga()
        {
            Console.WriteLine($"{PirmasSkaicius} * {AntrasSkaicius} = {PirmasSkaicius * AntrasSkaicius}");
        }

        public void Dalmuo()
        {
            Console.WriteLine($"{PirmasSkaicius} / {AntrasSkaicius} = {(double)PirmasSkaicius / AntrasSkaicius}");
        }
    }
}
