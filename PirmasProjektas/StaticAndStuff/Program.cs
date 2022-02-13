using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WordsDatabase wordsDatabase = new WordsDatabase();
                bool testi = true;
                while (testi)
                {
                    string ivestis = Console.ReadLine();
                    testi = wordsDatabase.Prideti(ivestis);
                }
            }
            catch(SkaiciausKlaida skKlaida)
            {
                Console.WriteLine($"Klaida: {skKlaida.Message}!");
            }

            Console.Read();
        }

        private static int NuskaitytiSkaiciu()
        {
            int sk = Convert.ToInt32(Console.ReadLine());

            if(sk < 0)
            {
                throw new SkaiciausKlaida();
            }

            return sk;
        }

        private static void Old()
        {

            Stopwatch sw = Stopwatch.StartNew();

            //string tekstas = "titulinis";
            //for(int i = 0; i < 10; i++)
            //{
            //    tekstas += " Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute Kazkokia eilute";
            //}
            //sw.Stop();
            //Console.WriteLine(tekstas);
            //Console.WriteLine($"Su string uztruko: {sw.ElapsedTicks}");

            sw = Stopwatch.StartNew();
            StringBuilder tekstoStatyojas = new StringBuilder();
            Random rnd = new Random();
            for (int i = 0; i < 1000; i++)
            {
                tekstoStatyojas.Append((char)rnd.Next(33, 124));
            }
            char[] iKurCopint = new char[100];

            tekstoStatyojas.CopyTo(0, iKurCopint, 5, 50);


            string naujasTekstas = tekstoStatyojas.ToString();
            sw.Stop();
            Console.WriteLine(naujasTekstas);
            Console.WriteLine($"I kur kopint: {iKurCopint.ToString()}");
            Console.WriteLine($"Su StringBuilder uztruko: {sw.ElapsedTicks}");

            //string manoTekstoEilute = "a b c";
            //string beTarpu = manoTekstoEilute.Replace(" ", "");
            //int kiekis = beTarpu.Length;
            //Console.WriteLine($"{manoTekstoEilute} Raidziu kiekis: {kiekis}");


            //string s = "titulinis";
            //string a = " lel";
            //string b = " lul";
            //List<string> stringx100 = new List<string>();
            //List<int> integer = new List<int>();
            //string concat = string.Concat(stringx100);
            //string join = string.Join("", stringx100);

            //Console.WriteLine(concat);
            //Console.WriteLine(join);
            //tekstoEilute = Pakeisti(tekstoEilute);
            //Console.WriteLine(tekstoEilute);
            Console.WriteLine("Programa baige darba!");
        }

        private static string Pakeisti(string s)
        {
            s += "ate";
            // atmintyje:
            // s1: labas
            // s2: labasate
            return s;
        }

        private static void Exceptionai()
        {
            try
            {
                string textas = "3,2...1";
                FormatuotiTeksta(textas);

                Console.WriteLine("Formatuoti pavyko!");
            }
            catch (FormatException formatoKlaida)
            {
                Console.WriteLine("Formato klaida! :(");
                Console.WriteLine(formatoKlaida.Message);
            }
            catch (NullReferenceException neegzistuojancioObjKlaida)
            {
                Console.WriteLine("Pasimete stringas...!");
            }
            catch (StringoLogikosKlaida logikosKlaida)
            {
                Console.WriteLine($"String eilutes klaida: {logikosKlaida.Message}");
                Console.WriteLine("Iveskite string eilute per nauja!");
            }
            catch (Exception exception)
            {
                Console.WriteLine("Kazkokia kita klaida...");
                Console.WriteLine(exception.Message);
            }


            Console.WriteLine("Programa tesiasi... super magic logic");
        }

        private static void FormatuotiTeksta(string raidinisTekstas)
        {
            if (raidinisTekstas.Contains("1"))
            {
                throw new StringoLogikosKlaida();
            }

            Console.WriteLine("Toliau vykdoma logika su string");

            //do magic with raidinisTekstas
        }

        private static void Enumas()
        {
            Vyras vyras = new Vyras(VedybinePadetis.Vedes);

            AtspausdintiVedybinePadeti(vyras.VedybinePadetis);
        }

        public static void AtspausdintiVedybinePadeti(VedybinePadetis vedybinePadetis)
        {
            switch (vedybinePadetis)
            {
                case VedybinePadetis.Nevedes:
                    Console.WriteLine("Dar ne vedes...");
                    break;
                case VedybinePadetis.Vedes:
                    Console.WriteLine("Jau vedes...");
                    break;
                default:
                    break;
            }
        }

        private static void Struktura()
        {
            //string sarasiuaks = "lolololo";
            //sarasiuaks.ManoParasytasMetodas();
            Console.ForegroundColor = (ConsoleColor)10;
            //Console.Read();
            ManoKlase klase = new ManoKlase("vienas");
            ManoStruktura s1 = new ManoStruktura();
            ManoStruktura struktura = new ManoStruktura("vienas");
            int i = 0;

            Pakeisti(klase);
            Pakeisti(struktura);
            Pakeisti(i);

            DateTime laikas = DateTime.Now;
            Pakeisti(laikas);

            Console.WriteLine("integer:");
            Console.WriteLine(i);

            Console.WriteLine("Struktura:");
            Console.WriteLine(struktura.ManoPropertis);
            struktura.ManoPropertis = "trys";

            Console.WriteLine("Klase:");
            Console.WriteLine(klase.ManoPropertis);
            Console.WriteLine("Struktura:");
            Console.WriteLine(struktura.ManoPropertis);
        }

        private static void Pakeisti(DateTime laikas)
        {
            laikas = DateTime.MinValue;
        }

        private static void Pakeisti(ManoKlase klase)
        {
            klase.ManoPropertis = "Du";
        }
        private static void Pakeisti(ManoStruktura struktura)
        {
            struktura.ManoPropertis = "Du";
        }

        private static void Pakeisti(int i)
        {
            i = 5;
        }
    }
}
