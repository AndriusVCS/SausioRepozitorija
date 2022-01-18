using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klases
{
    class Program
    {
        /* Apsilimui
         * Klase skaiciuotuvas
         * 4 metodai:
         * Suma() - issaugotus skaicius sumuoja ir isveda i ekrana rezultata
         * Atimtis() - issaugotus skaicius atima ir isveda i ekrana rezultata
         * Daugyba() - issaugotus skaicius daugina ir isveda i ekrana rezultata
         * Dalyba() - issaugotus skaicius dalina ir isveda i ekrana rezultata
         * konstruktorius kuris priimtu 2 skaicius ir juos prisikirtu klases viduje
         * Susikurti 3 skaiciuotuvo objektus su pasirinktais skirtingais skaiciais
         */

        /*
        Uzduotis 1:

        * Sukurti klase Apskritimas, kuriai per konstruktoriu paduodamas apskritimo spindylys. Realizuoti metodus GautiPlota ir GautiIlgi. 
        * * ilgis = 2 * pi * spindulys 
        * * plotas = pi * spindulys * spindulys
        * 
        * Sukurti klase Keturkampis, kuriai per konstruktoriu paduodami keturkampio krastiniu ilgiai. Realizuoti metodus GautiPlota ir GautiPerimetra.
        * * a ir b krastines
        * * plotas = a * b
        * * perimetras = 2 * a + 2 * b
        * 
        * Sukurti klase Trikampis, kuriai per konstruktoriu paduodama trikampio trys krastines.  Realizuoti metodus GautiPerimetra, GautiPusperimetri ir GautiPlota()
        * * perimetras = a + b + c
        * * pusperimetris = perimetras / 2
        * * plotas = Math.Sqrt(pusperimetris * (pusperimetris - a) * (pusperimetris - b) * (pusperimetris - c));
        */

        static void Main(string[] args)
        {
            UzdavinysMedis();
            Console.ReadKey();
        }

        private static void UzdavinysMedis()
        {
            Medis medis = new Medis();
            string[] allowedStrings = new string[] { "y", "t", "yes", "taip" };
            Console.WriteLine("Ar norite auginti medi?");
            while (allowedStrings.Contains(Console.ReadLine().ToLower()))
            {
                medis.Augti();
                Console.WriteLine("Ar norite auginti medi?");
            }

            Console.WriteLine($"Medis turi {medis.SakuSkaicius} saku!");
        }

        private static void UzklojimoPavyzdys()
        {
            Zmogus zmogus1 = new Zmogus("Andrius", "vyr");
            Zmogus zmogus2 = new Zmogus("Kazkas");

            Console.WriteLine($"zmogus1 vardas: {zmogus1.Vardas}, lytis: {zmogus1.Lytis}");
            Console.WriteLine($"zmogus2 vardas: {zmogus2.Vardas}, lytis: {zmogus2.Lytis}");

        }

        private static void TrikampioPavyzdys()
        {
            Trikampis trikampis1 = new Trikampis(4, 4, 5);
            Trikampis trikampis2 = new Trikampis(4, 8, 6);
            trikampis1.A = 0;

            Console.WriteLine($"Trikampis1 perimetras: {trikampis1.GautiPerimetra()}, pusperimetris: {trikampis1.GautiPusperimetri()}, plotas: {trikampis1.GautiPlota()}");
            Console.WriteLine($"Trikampis1 perimetras: {trikampis2.GautiPerimetra()}, pusperimetris: {trikampis2.GautiPusperimetri()}, plotas: {trikampis2.GautiPlota()}");
        }


        private static void KeturkampioPavyzdys()
        {
            Keturkampis keturkampis1 = new Keturkampis(4, 6);
            Keturkampis keturkampis2 = new Keturkampis(7, 8);

            Console.WriteLine($"Keturkampis1 perimetras: {keturkampis1.GautiPerimetra()}, perimetras apskliaudus: {keturkampis1.GautiPerimetraApskliaudus()}, plotas: {keturkampis1.GautiPlota()}");
            Console.WriteLine($"Keturkampis2 perimetras: {keturkampis2.GautiPerimetra()}, perimetras apskliaudus: {keturkampis2.GautiPerimetraApskliaudus()}, plotas: {keturkampis2.GautiPlota()}");
        }

        private static void ApskritimoSample()
        {
            Apskritimas apskritimas1 = new Apskritimas(5);
            Apskritimas apskritimas2 = new Apskritimas(10);

            Console.WriteLine($"Pirmo apskritimo spindulys: {apskritimas1.Spindulys}, ilgis: {apskritimas1.GautiIlgi()}, plotas: {apskritimas1.GautiPlota()}");
            Console.WriteLine($"Antro apskritimo spindulys: {apskritimas2.Spindulys}, ilgis: {apskritimas2.GautiIlgi()}, plotas: {apskritimas2.GautiPlota()}");
        }

        private static void SkaiciuotuvoSample()
        {
            Skaiciuotuvas pirmas = new Skaiciuotuvas(1, 2);
            Skaiciuotuvas antras = new Skaiciuotuvas(3, 4);
            Skaiciuotuvas trecias = new Skaiciuotuvas(5, 6);

            pirmas.Suma();
            antras.Suma();
            trecias.Suma();
        }
    }
}
