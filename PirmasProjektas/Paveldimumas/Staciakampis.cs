using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paveldimumas
{
    class Staciakampis : Figura, IGeometrija, IInformacija
    {
        public double A { get; }
        public double B { get; }

        public Staciakampis(double a, double b) : base("Staciakampis")
        {
            A = a;
            B = b;
        }

        public double GautiPlota()
        {
            return A * B;
        }

        public double GautiPerimetra()
        {
            return 2 * A + 2 * B;
        }

        public void Info()
        {
            Console.WriteLine($"{Pavadinimas} A: {A} B: {B} Plotas: {GautiPlota()} Perimetras: {GautiPerimetra()}");
        }
    }
}
