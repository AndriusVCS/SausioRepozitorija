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

            Console.Read();
        }


        private static void PirmaUzduotis()
        {
            Console.WriteLine("Iveskite pirma skaiciu:");
            int pirmasSkaicius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite antra skaiciu:");
            int antrasSkaicius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite trecia skaiciu:");
            int treciasSkaicius = Convert.ToInt32(Console.ReadLine());

            switch (pirmasSkaicius)
            {
                case 1:
                    Console.WriteLine($"Visu triju skaiciu suma: {pirmasSkaicius + antrasSkaicius + treciasSkaicius}");
                    break;
                case 2:
                    Console.WriteLine($"Pirmo ir trecio skaiciu suma: {pirmasSkaicius + treciasSkaicius}");
                    break;
                case 3:
                    Console.WriteLine($"Antro ir trecio skaiciu suma: {antrasSkaicius + treciasSkaicius}");
                    break;
                default:
                    break;
            }
        }

        private static void AntraUzduotis()
        {

            Console.WriteLine("Iveskite pasrinkima:");
            Console.WriteLine("1 - limonadas");
            Console.WriteLine("2 - arbata");
            Console.WriteLine("3 - kakava");
            Console.WriteLine("4 - kava");
            Console.WriteLine("5 - nieko");

            int pasirinkimas = Convert.ToInt32(Console.ReadLine());

            switch (pasirinkimas)
            {
                case 1:
                    Console.WriteLine("Pasirinkote limonada!");
                    break;
                case 2:
                    Console.WriteLine("Pasirinkote arbata!");
                    break;
                case 3:
                    Console.WriteLine("Pasirinkote kakava!");
                    break;
                case 4:
                    Console.WriteLine("Pasirinkote kava!");
                    break;
                case 5:
                    Console.WriteLine("Pasirinkote nieko!");
                    break;
                default:
                    Console.WriteLine("Blogai ivestas pasirinkimas!");
                    break;
            }

        }
    }
}
