using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paveldimumas
{
    class StatusisTrikampis : Figura, IGeometrija, IInformacija
    {
        public double A { get; }
        public double B { get; }

        public StatusisTrikampis(double a, double b) : base("Statusis trikampis")
        {
            A = a;
            B = b;
        }

        public double GautiPlota()
        {
            return A * B / 2;
        }

        public double GautiPerimetra()
        {
            double c = Math.Sqrt(A * A + B * B);
            return A + B + c;
        }

        public void Info()
        {
            Console.WriteLine($"{Pavadinimas} A: {A} B: {B} Plotas: {GautiPlota()} Perimetras: {GautiPerimetra()}");
        }
    }
}
