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
            //string[] studentuVardai = new string[2];
            //studentuVardai[0] = Console.ReadLine();
            //studentuVardai[1] = Console.ReadLine();

            //int[] pirmasBudas = { 1, 2, 3, 9 };
            int[] antrasBudas = { 1, 2, 3, 9 };

            SpausdintiMasyvoDydi(antrasBudas);

            Console.WriteLine(antrasBudas[0]);
            // Suma(pirmasSkaicius, antrasSkaicius);
            // Atimtis(pirmasSkaicius, antrasSkaicius);
            // Sandauga(pirmasSkaicius, antrasSkaicius);
            // Dalmuo(pirmasSkaicius, antrasSkaicius);

            Console.Read();
        }

        private static void SpausdintiMasyvoDydi(int[] masyvas)
        {
            masyvas[0] = 10;
        }

        private static int Suma(int a, int b)
        {
            return a + b;
        }
    }
}
