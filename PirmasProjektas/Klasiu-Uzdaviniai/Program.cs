using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasiu_Uzdaviniai
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        private static void UzdavinysSnipas()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            // Sukurimas
            List<Snipas> manosnipai = SukurtiSnipus(n);

            // Naudojimas
            Infiltruotis(manosnipai);

            Console.ReadLine();
        }

        private static List<Snipas> SukurtiSnipus(int n)
        {
            List<Snipas> snipuSarasas = new List<Snipas>();
            for (int i = 0; i < n; i++)
            {
                Snipas snipas = new Snipas($"agent00{i}");
                snipuSarasas.Add(snipas);
            }
            return snipuSarasas;
        }

        private static void Infiltruotis(List<Snipas> snipuSarasas)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("*************************");
                for (int j = 0; j < i; j++)
                {
                    snipuSarasas[i - 1].Infiltruotis();
                }

                Console.WriteLine($"{snipuSarasas[i - 1].Vardas} Infiltruojuosi {snipuSarasas[i - 1].InfiltracijuKiekis} karta!");
            }
        }
    }
}
