using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciklai
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = { 1, 2, 3 };
            byte b = 2;
            Console.WriteLine(mas[b]);
            Console.WriteLine("Pasirinkite 1 (BMW) arba 2 (AUDI)");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            bool prasytIvesti = true;
            while (prasytIvesti)
            {
                switch (skaicius)
                {
                    case 1:
                        prasytIvesti = false;
                        break;
                    case 2:
                        prasytIvesti = false;
                        break;
                    default:
                        Console.WriteLine("Blogas skaicius, kartokite!");
                        skaicius = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            Console.WriteLine($"Ivedete {skaicius}!");
            Console.Read();
        }

        private static void PasakytiLabasNKartu(int n)
        {
       
            for (int i = 0; i < n - 1; i++)
            {
                string t = $"{i,100}";
                Console.WriteLine($"{i, 100}");
            }
        }

        private static int SkaiciuSuma()
        {
            int suma = 0;
            for(int i = 0; i < 1000; i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    suma += i;
                }
            }

            return suma;
        }
    }
}
