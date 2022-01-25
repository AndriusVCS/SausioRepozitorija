using System;
using System.Collections.Generic;

namespace Paveldimumas
{
    class Program
    {
        static void Main(string[] args)
        {
            Zaidimas manoZaidimas = new Zaidimas();
            manoZaidimas.Pradeti();

            //ZmogausUzdavinys();
            Console.ReadLine();
        }

        private static void ZmogausUzdavinys()
        {
            Zmogus zmogus = new Zmogus("Petras", "Petrauskas");
            Pilietis pilietis = new Pilietis("Jonas", "Jonaitis", 123456789, "Lietuvis");
            Gyventojas gyventojas = new Gyventojas("Lukas", "Lukaitis", 987654321, "Anglas", "Londonas");

            zmogus.Info();
            Console.WriteLine("************");
            pilietis.Info();
            Console.WriteLine("************");
            gyventojas.Info();
        }

        private static void KaladesUzdavinys()
        {
            KortuKalade kalade = new KortuKalade();

            foreach (Korta korta in kalade.KortuSarasas)
            {
                Console.WriteLine($"{korta.Pavadinimas} {korta.Verte} {korta.Zenklas}");
            }

            Console.WriteLine($"Viso kortu: {kalade.KortuSarasas.Count}");
        }
    }
}
