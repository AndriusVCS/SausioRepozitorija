using System;

namespace Paveldimumas
{
    public class Pilietis : Zmogus
    {
        public int AsmensKodas { get; }
        public string Pilietybe { get; }

        public Pilietis(string vardas, string pavarde, int asmensKodas, string pilietybe) : base(vardas, pavarde)
        {
            AsmensKodas = asmensKodas;
            Pilietybe = pilietybe;
        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine($"Mano a.k. {AsmensKodas} ir pilietybe {Pilietybe}");
        }

    }
}
