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
            PirmaUzduotis();
            //AntraUzduotis();
            //TreciaUzduotis();
            //KetvirtaUzduotis();

            Console.Read();
        }  

        private static void PirmaUzduotis()
        {
            Console.WriteLine("Programa pradejo darba!");
        }

        private static void AntraUzduotis()
        {
            Console.WriteLine("Iveskite savo varda:");
            string vardas = Console.ReadLine();

            Console.WriteLine("Iveskite savo amziu:");
            int amzius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite savo hobi:");
            string hobis = Console.ReadLine();

            Pasisveikinti(vardas, amzius, hobis);
        }

        private static void Pasisveikinti(string vardas, int amzius, string hobis)
        {
            Console.WriteLine($"Labas, {vardas} ({amzius} m.). ");
            Console.WriteLine($"Jusu irasytas hobis: {hobis}");
        }

        private static void TreciaUzduotis()
        {
            Console.WriteLine("Iveskite pirma skaiciu:");
            int pirmasSkaicius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite antra skaiciu:");
            int antrasSkaicius = Convert.ToInt32(Console.ReadLine());
            Suma(pirmasSkaicius, antrasSkaicius);
            Atimtis(pirmasSkaicius, antrasSkaicius);
            Daugyba(pirmasSkaicius, antrasSkaicius);
            Dalyba(pirmasSkaicius, antrasSkaicius);
        }

        private static void Suma(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        private static void Atimtis(int a, int b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }

        private static void Daugyba(int a, int b)
        {
            Console.WriteLine($"{a} * {b} = {a * b}");
        }

        private static void Dalyba(int a, int b)
        {
            Console.WriteLine($"{a} / {b} = {(double)a / b}");
        }

        private static void KetvirtaUzduotis()
        {
            string[] identifikacija = new string[2];
            int[] skaiciai = new int[2];

            Console.WriteLine("Iveskite varda:");
            identifikacija[0] = Console.ReadLine();

            Console.WriteLine("Iveskite pavarde:");
            identifikacija[1] = Console.ReadLine();

            Console.WriteLine("Iveskite amziu:");
            skaiciai[0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite megstamiausia skaiciu:");
            skaiciai[1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Labas {identifikacija[0]} {identifikacija[1]}!");
            Console.WriteLine($"Tau {skaiciai[0]} ir tavo megstamiausias skaicius {skaiciai[1]}!");

            Console.WriteLine();
        }
    }
}

