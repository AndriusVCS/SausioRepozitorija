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
            PenktaUzduotis();

            Console.Read();
        }

        public static void PirmaUzduotis()
        {
            int pirmasSkaicius = Convert.ToInt32(Console.ReadLine());
            int antrasSkaicius = Convert.ToInt32(Console.ReadLine());

            if (pirmasSkaicius > antrasSkaicius)
            { 
                Console.WriteLine($"Pirmas skaicius didesnis: {pirmasSkaicius}");
            }

            if(antrasSkaicius > pirmasSkaicius)
            {
                Console.WriteLine($"Antras skaicius didesnis: {antrasSkaicius}");
            }

            if(antrasSkaicius == pirmasSkaicius)
            {
                Console.WriteLine($"Skaiciai lygus: {pirmasSkaicius} == {antrasSkaicius}");
            }
        }

        public static void AntraUzduotis()
        {
            int skaicius = Convert.ToInt32(Console.ReadLine());
            if (skaicius % 2 == 0)
            {
                Console.WriteLine($"Skaicius {skaicius} yra lyginis!");
            }
        }

        public static void TreciaUzduotis()
        {
            int pirmasSkaicius = Convert.ToInt32(Console.ReadLine());
            int antrasSkaicius = Convert.ToInt32(Console.ReadLine());
            int amzius = Convert.ToInt32(Console.ReadLine());

            if(amzius > pirmasSkaicius)
            {
                Console.WriteLine($"Amzius yra didesnis nei pirmas skaicius didesnis: {amzius} > {pirmasSkaicius}");
            }
            else if(amzius > antrasSkaicius)
            {
                Console.WriteLine($"Amzius yra didesnis nei antras skaicius didesnis: {amzius} > {antrasSkaicius}");
            }
        }

        public static void KetvirtaUzduotis()
        {
            int pirmasSkaicius = Convert.ToInt32(Console.ReadLine());
            int antrasSkaicius = Convert.ToInt32(Console.ReadLine());
            int amzius = Convert.ToInt32(Console.ReadLine());

            if (amzius > pirmasSkaicius)
            {
                Console.WriteLine($"Amzius yra didesnis nei pirmas skaicius didesnis: {amzius} > {pirmasSkaicius}");
            }
            else if (amzius > antrasSkaicius)
            {
                Console.WriteLine($"Amzius yra didesnis nei antras skaicius didesnis: {amzius} > {antrasSkaicius}");
            }
            else
            {
                Console.WriteLine("Amzius nera didesnis nei uz viena skaiciu!");
            }
        }

        public static void PenktaUzduotis()
        {
            int pirmasSkaicius = Convert.ToInt32(Console.ReadLine());
            int antrasSkaicius = Convert.ToInt32(Console.ReadLine());
            int treciasSkaicius = Convert.ToInt32(Console.ReadLine());

            if(pirmasSkaicius > antrasSkaicius && pirmasSkaicius > treciasSkaicius)
            {
                Console.WriteLine("Pirmas skaicius didziausias!");
            }
            else if (antrasSkaicius > pirmasSkaicius && antrasSkaicius > treciasSkaicius)
            {
                Console.WriteLine("Antras skaicius didziausias!");
            }
            else if (treciasSkaicius > pirmasSkaicius && treciasSkaicius > antrasSkaicius)
            {
                Console.WriteLine("Trecias skaicius didziausias!");
            }
            else
            {
                Console.WriteLine("Yra keli didziausi skaiciai");
            }

        }
    }
}
