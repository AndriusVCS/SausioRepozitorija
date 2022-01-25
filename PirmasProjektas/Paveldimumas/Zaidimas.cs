using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paveldimumas
{
    class Zaidimas
    {
        public List<Zaidejas> Zaidejai { get; }
        public KortuKalade KortuKalade { get; private set; }

        public Zaidimas()
        {
            Zaidejai = new List<Zaidejas>();
            KortuKalade = new KortuKalade();
        }

        public void SuskaiciuotiTaskus()
        {

        }

        public void Pradeti()
        {
            KortuKalade = new KortuKalade();
            KortuKalade.Sumaisyti();

            Zaidejai.Clear();
            Console.WriteLine("Kiek bus zaideju? 2 ar 4?");
            int zaidejuSkaicius = Convert.ToInt32(Console.ReadLine());

            while(zaidejuSkaicius != 2 && zaidejuSkaicius != 4)
            {
                Console.WriteLine("Blogas zaideju skaicius! Kiek bus zaideju? 2 ar 4?");
                zaidejuSkaicius = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i < zaidejuSkaicius; i++)
            {
                Console.WriteLine($"Ivesti {i + 1}-o varda:");
                string zaidejoVardas = Console.ReadLine();
                Zaidejai.Add(new Zaidejas(zaidejoVardas));
            }

            IsdalintiKortas();

            foreach (Zaidejas zaidejas in Zaidejai)
            {
                Console.WriteLine($"Zaidejo {zaidejas.Vardas} ({zaidejas.Kortos.Count}) kortos:");
                foreach (Korta korta in zaidejas.Kortos)
                {
                    Console.WriteLine($"{korta.Zenklas} {korta.Pavadinimas}");
                }
            }
        }

        public void IsdalintiKortas()
        {
            // Kortos - ismaisytos
            // Zaideju skaicius - aiskus
            // Zinom kiek yra kortu kortu kaladeje
            int kortuIRankaKiekis = KortuKalade.KortuSarasas.Count / Zaidejai.Count;
            foreach (Zaidejas zaidejas in Zaidejai)
            {
                for(int i = 0; i < kortuIRankaKiekis; i++)
                {
                    zaidejas.Kortos.Add(KortuKalade.KortuSarasas[0]);
                    KortuKalade.KortuSarasas.RemoveAt(0);
                }
            }
        }

    }
}
