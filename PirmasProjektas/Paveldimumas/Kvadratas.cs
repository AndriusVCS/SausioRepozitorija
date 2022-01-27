using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paveldimumas
{
    class Kvadratas : Figura, IGeometrija, IInformacija
    {
        public double A { get; }
        public Kvadratas(double a) : base("Kvadratas")
        {
            A = a;
        }

        public double GautiPlota()
        {
            return A * A;
        }

        public double GautiPerimetra()
        {
            return A * 4;
        }

        public void Info()
        {
            Console.WriteLine($"{Pavadinimas} A: {A} Plotas: {GautiPlota()} Perimetras: {GautiPerimetra()}");
        }
    }
}
