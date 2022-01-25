using System;
using System.Collections;
using System.Collections.Generic;

namespace Paveldimumas
{
   
    class Program
    {
        static void Main(string[] args)
        {
            InterfacePavyzdys();

            //ZmogausUzdavinys();
            Console.ReadLine();
        }

        private static void InterfacePavyzdys()
        {
            List<IGaliuEiti> ejikai = new List<IGaliuEiti>();
            ejikai.Add(new Zmogus("Vardenis", "Pavardenis"));
            ejikai.Add(new Suniukas());

            foreach (IGaliuEiti ejikas in ejikai)
            {
                ejikas.Eiti();

                if(ejikas is Zmogus zmogausObjektas)
                {
                    // Pavyzdys, kaip galima isgauti originalu objekto tipa, naudojant interface. Jeigu ejikas bus zmogus, papulsime i if salygos vykdyma
                    // Ir turesime zmogausObjektas objekta, kuris jau bus traktuojamas kaip Zmogus tipo
                    Console.WriteLine(zmogausObjektas.Pavarde);
                }

                // Retesnis pavyzdys, kaip galima isgauti originalu objekto tipa, naudojant interface
                switch (ejikas)
                {
                    case Zmogus zmogas:
                        Console.WriteLine(zmogas.Vardas);
                        break;
                    case Suniukas suo:
                        Console.WriteLine("Suo");
                        break;
                }
            }
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
