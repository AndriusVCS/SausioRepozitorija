using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PirmasProjektas.Antras;
using System.Globalization;

namespace PirmasProjektas
{
    class Program
    {
        static void Main(string[] args)
        {
            //PirmaUzduotis();
            //AntraUzduotis();
            //TreciaUzduotis();
            //KetvirtaUzduotis();
            //WhilePirmaUzduotis();
            WhileAntraUzduotis();

            Console.Read();
        }

        private static void PirmaUzduotis()
        {
            Console.WriteLine("Pirmas budas:");
            for(int i = 0; i < 20; i ++)
            {
                if(i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Antras budas:");
            for (int i = 0; i < 20; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        private static void AntraUzduotis()
        {
            Console.WriteLine("Ivesti rezius [x - y]:");
            int pirmasRezis = Convert.ToInt32(Console.ReadLine());
            int antrasRezis = Convert.ToInt32(Console.ReadLine());

            if(pirmasRezis > antrasRezis)
            {
                Console.WriteLine("Blogi reziai!");
            }
            else
            {
                for(int i = pirmasRezis; i < antrasRezis; i++)
                {
                    Console.WriteLine($"{i} {i * i}");
                }
            }
        }

        private static void TreciaUzduotis()
        {
            int suma = 0;
            for(int i = 0; i < 1000; i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    suma += i;
                }
            }

            Console.WriteLine($"Suma: {suma}");
        }
        private static void KetvirtaUzduotis()
        {
            int suma = 1;
            for (int i = 1; i < 100; i++)
            {
                if (i % 7 == 0)
                {
                    suma *= i;
                }
            }

            Console.WriteLine($"Rezultatas: {suma}");
        }

        private static void WhilePirmaUzduotis()
        {
            Console.WriteLine($"Iveskite pasirinkima (1 - laptopas arba 2 - stacionaras):");

            int pasirinkimas = Convert.ToInt32(Console.ReadLine());

            while(pasirinkimas != 1 && pasirinkimas != 2)
            {
                Console.WriteLine("Ivyko klaida! Veskite per nauja!");
                pasirinkimas = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"Pasirinkote - {pasirinkimas}");
        }


        private static void WhileAntraUzduotis()
        {
            Console.WriteLine($"Iveskite skaiciu:");

            int skaicius = Convert.ToInt32(Console.ReadLine());
            int suma = 0;
            while (skaicius > 0)
            {
                if(skaicius % 2 == 0)
                {
                    suma += skaicius;
                }

                Console.WriteLine($"Dabartinis skaicius {skaicius}");
                skaicius--;
            }

            Console.WriteLine($"Lyginiu skaiciu suma: {suma}!");
        }
    }
}
