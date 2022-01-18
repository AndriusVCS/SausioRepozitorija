using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klases
{
    class Keturkampis
    {
        public double A;
        public double B;

        public Keturkampis(double a, double b)
        {
            A = a;
            B = b;
        }

        public double GautiPerimetra()
        {
            return 2 * A + 2 * B;
        }

        public double GautiPerimetraApskliaudus()
        {
            return (2 * A) + (2 * B);
        }

        public double GautiPlota()
        {
            return A * B;
        }
    }
}
