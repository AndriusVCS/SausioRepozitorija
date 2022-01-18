using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klases
{
    class Zmogus
    {
        private string _vardas;

        public string Lytis { get; }
        public string Vardas { get { return _vardas + "A"; } private set { _vardas = value + "B"; } }

        public Zmogus(string vardas)
        {
            Vardas = vardas;
        }

        public Zmogus(string[] credentials)
        {
            Vardas = credentials[0];
            Lytis = credentials[1];
        }

        public Zmogus(string vardas, string lytis)
        {
            Vardas = vardas;
            Lytis = lytis;
        }

        public void Keisti(string naujasVardas, string naujaLyis)
        {
            Vardas = naujasVardas;
            // Lytis = naujaLyis; - negalima, readonly
        }

        public void Keisti(string naujasVardas)
        {

        }

        public void Keisti()
        {

        }
    }
}
