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
            TreciaUzduotis();
        }

        public static void PirmaUzduotis()
        {
            Console.WriteLine($"Andrius Jankauskas 27");

            Console.ReadKey();
        }

        public static void AntraUzduotis()
        {
            string ivestis = Console.ReadLine();

            Console.WriteLine(ivestis);

            Console.ReadKey();
        }
        public static void TreciaUzduotis()
        {
            Console.WriteLine("Iveskite savo varda:");
            string vardas = Console.ReadLine();
            Console.WriteLine("Iveskite savo megstamiausios spalvos pirma raide:");
            
            char spalvosRaide = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.WriteLine("Iveskite pirma skaiciu:");
            double pirmasSkaicius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Iveskite pirma skaiciu:");
            double antrasSkaicius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Mano vardas {vardas}, mano megstamiausios spalvos pirma raide {spalvosRaide}");
            Console.WriteLine($"Ivesti skaiciai: {pirmasSkaicius} ir {antrasSkaicius}");

            Console.ReadKey();
        }

    }
}
