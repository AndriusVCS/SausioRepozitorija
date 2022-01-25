using System;

namespace Paveldimumas
{
    public class Zmogus
    {
        public string Vardas { get; }
        public string Pavarde { get; }

        public Zmogus(string vardas, string pavarde)
        {
            Vardas = vardas;
            Pavarde = pavarde;
        }

        public virtual void Info()
        {
            Console.WriteLine($"Labas! As esu zmogus ir mano vardas {Vardas} {Pavarde}!");
        }
    }
}
