using System;

namespace Klases
{
    class Apskritimas
    {
        public double Spindulys;

        public Apskritimas(double spindulys)
        {
            Spindulys = spindulys;
        }

        public double GautiIlgi()
        {
            return 2 * Math.PI * Spindulys;
        }

        public double GautiPlota()
        {
            return Math.PI * Spindulys * Spindulys;
        }
    }
}
