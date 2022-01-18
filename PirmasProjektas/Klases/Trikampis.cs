using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klases
{
    class Trikampis
    {
        public double A;
        public double B;
        public double C;
        
        public Trikampis(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double GautiPerimetra()
        {
            return A + B + C;
        }

        public double GautiPusperimetri()
        {
            return GautiPerimetra() / 2;
        }

        public double GautiPlota()
        {
            double pusperimetris = GautiPusperimetri();
            double plotas = Math.Sqrt(pusperimetris * (pusperimetris - A) * (pusperimetris - B) * (pusperimetris - C));
            return plotas;
        }
    }
}
