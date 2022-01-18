using System;
using System.Collections.Generic;
using System.Linq;

namespace Listai
{
    class Program
    {
        static void Main(string[] args)
        {
            PraktikaSuDictionary();
            Console.ReadKey();
        }

        /*
          Isvesti piramide i console, tokio aukscio, kiek vartotojas ivede
        pvz: 4

           *
          * * 
         * * *
        * * * *
        
         */
        public static void ZvaigzduciuPiramide()
        {
            Console.WriteLine("Iveskite auksti:");
            if(int.TryParse(Console.ReadLine(), out int aukstis))
            {
                for(int i = 0; i < aukstis; i++)
                {

                }
            }
        }

        private static void Test<T>(IEnumerable<T> sarasas) where T : struct
        {
            foreach (var item in sarasas)
            {

            }
        }


        /* Praktika su Dictionary
         1. Tuscias Zodynas (Dictionary) kurio raktas string ir reiksme int - Dictionary<string, int> zodynas
         2. while ciklas tol kol vartotojas neives jau esamo rakto i zodyna
         3. Isprintinti visus ivestus raktus ir reiksmes poromis $"{raktas} {reiksme}"
         4. Paprasyti vartotojo kad ivestu rakta, kurio reiksme atspausdinti i ekrana
         */
        public static void PraktikaSuDictionary()
        {
            Dictionary<string, int> zodynas = new Dictionary<string, int>();

            Dictionary<string, int>.ValueCollection s = zodynas.Values;

            string ivestis = Console.ReadLine();
            string[] elementai = ivestis.Split(',');

            // (salyga == false)
            // arba
            // (!salyga)
            while (!zodynas.ContainsKey(elementai[0]))
            {
                int skaicius = Convert.ToInt32(elementai[1]);
                zodynas.Add(elementai[0], skaicius);

                ivestis = Console.ReadLine();
                elementai = ivestis.Split(',');
            }

            foreach (KeyValuePair<string, int> pora in zodynas)
            {
                Console.WriteLine($"{pora.Key} {pora.Value}");
            }

            Console.WriteLine("Iveskite rakta, kurio reiksmes norite:");
            string ivestasRaktas = Console.ReadLine();

            bool arPavykoRasti = zodynas.TryGetValue(ivestasRaktas, out int reiksme);
            if (arPavykoRasti)
            {
                Console.WriteLine($"Reiksme: {reiksme}");
            }
            else
            {
                Console.WriteLine($"Reiksme nerasta, blogas raktas!");
            }
        }

        public static void ForeachPavyzdys(List<List<int>> manoKolekcija)
        {
            foreach (var sarasas in manoKolekcija)
            {
                foreach(var sarasoSarasas in sarasas)
                {
                    Console.WriteLine(sarasoSarasas);
                }
            }
        }

        /* Praktika su List, Foreach
        1. Tuscias sveikuju skaiciu sarasa (List<int>)
        2. while ciklas tol kol vartotojas neives neigiamo skaiciaus
        3. Isprintinti visus skaicius su: for ciklu, foreach ciklu
        4. Isprintinti visu skaiciu suma
        5. Isprintinti visu skaiciu kvardratus
        */
        public static void PracticeSuForeach()
        {
            List<int> skaiciusSarasas = new List<int>();

            int skaicius = Convert.ToInt32(Console.ReadLine());

            while (skaicius >= 0)
            {
                skaiciusSarasas.Add(skaicius);
                skaicius = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Su for ciklu:");
            for (int i = 0; i < skaiciusSarasas.Count; i++)
            {
                Console.WriteLine($"({i}) Skaicius yra: {skaiciusSarasas[i]}");
            }

            Console.WriteLine("Su foreach ciklu:");
            // for(int i = 0; i < skaiciusSarasas.Count; i++)
            foreach (int ivestasSkaicius in skaiciusSarasas)
            {
                Console.WriteLine($"Skaicius yra: {ivestasSkaicius}");
            }
        }


        public static void ZodynoPavyzdys()
        {
            Dictionary<string, int> amziuZodynas = new Dictionary<string, int>();

            amziuZodynas.Add("Tomas Vardenis", 28);
            amziuZodynas.Add("Andrius Jankauskas", 27);

            string norimasRaktas = "Andrius Jankauskas1";

            bool arPavyko = amziuZodynas.TryGetValue(norimasRaktas, out int rastasAmzius);

            Console.WriteLine($"Rasti pavyko: {arPavyko}, rastas amzius: {rastasAmzius}");
            
        }

        public static void SarasoPavyzdys()
        {
            List<int> manoSarasas = new List<int>();
            manoSarasas.Add(1);
            manoSarasas.Add(3);
            manoSarasas.Add(2);

            manoSarasas.AddRange(new List<int> { 2, 6, 8 });
            manoSarasas.Sort();
            manoSarasas.Reverse();

            Console.WriteLine(manoSarasas.Sum());

            for (int i = 0; i < manoSarasas.Count; i++)
            {
                Console.WriteLine(manoSarasas[i]);
            }

            Console.ReadLine();
        }
    }
}
