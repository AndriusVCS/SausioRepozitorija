using System;

namespace Paveldimumas
{
    public class Zmogus : IGaliuEiti, IGaliuKalbeti
    {
        public string Vardas { get; }
        public string Pavarde { get; }

        public const string Vardas2 = "Andrius";
        public static string Vardas3 = "Jonas";

        private readonly string _megstamiausiaSpalva;

        public Zmogus(string vardas, string pavarde)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            _megstamiausiaSpalva = "Raudona";
        }

        public virtual void Info()
        {
            Console.WriteLine($"Labas! As esu zmogus ir mano vardas {Vardas} {Pavarde}!");
        }

        public void Eiti()
        {
            Console.WriteLine("Einu dviejomis kojomis!");
        }

        public void Kalbeti()
        {
            Console.WriteLine("Kalbu, labas!");
        }
    }
}
