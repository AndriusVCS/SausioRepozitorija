using System.Collections.Generic;

namespace Paveldimumas
{
    class Zaidejas
    {
        public string Vardas { get; }
        public List<Korta> Kortos { get; }

        public Zaidejas(string vardas)
        {
            Vardas = vardas;
            Kortos = new List<Korta>();
        }
    }
}
