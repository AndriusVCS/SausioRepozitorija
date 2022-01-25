using System;

namespace Paveldimumas
{
    public class Gyventojas : Pilietis
    {
        public string GyvenamojiVieta { get; }

        public Gyventojas(string vardas, string pavarde, int asmensKodas, string pilietybe, string gyvenamojiVieta) : base(vardas, pavarde, asmensKodas, pilietybe)
        {
            GyvenamojiVieta = gyvenamojiVieta;
        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine($"Mano gyvenamoji vieta: {GyvenamojiVieta}");
        }

    }
}
