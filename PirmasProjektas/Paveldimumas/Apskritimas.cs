using System;

namespace Paveldimumas
{
    class Apskritimas : Figura, IGeometrija, IInformacija
    {
        public double Spindulys { get; }

        public Apskritimas(double spindulys) : base("Apskritimas")
        {
            Spindulys = spindulys;
        }

        public double GautiPlota()
        {
            return Math.PI * Spindulys * Spindulys;
        }

        public double GautiPerimetra()
        {
            return 2 * Math.PI * Spindulys;
        }

        public void Info()
        {
            Console.WriteLine($"{Pavadinimas} Spindulys: {Spindulys} Plotas: {GautiPlota()} Perimetras: {GautiPerimetra()}");
        }

        public override void Metodas2()
        {
            throw new NotImplementedException();
        }
    }
}
