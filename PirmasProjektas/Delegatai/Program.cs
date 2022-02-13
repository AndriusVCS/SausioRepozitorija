using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatai
{
    public delegate void DoOpearation(int a, int b);
    //public delegate void EventHandler<TEventArgs>(object sender, TEventArgs args);

    class Program
    {
        public DoOpearation doOperation;
        public event EventHandler<string> OnChanged;

        static void Main(string[] args)
        {
     

            Console.Read();
        }

        private static void GenericsPvz()
        {
            BendrineKlase<VaikoKlase> objektas = new BendrineKlase<VaikoKlase>();
            BendrineKlase<TevineKlase> objektas2 = new BendrineKlase<TevineKlase>();
        }

        private static void LambdaUzduotis()
        {
            List<Studentas> sarasas = new List<Studentas>()
            {
                new Studentas(0, "Antanas", 17, 7.5, false),
                new Studentas(1, "Petras", 20, 9.3, true),
                new Studentas(2, "Jonas", 37, 7.3, false),
                new Studentas(3, "Tomas", 19, 8.1, true),
                new Studentas(4, "Mantas", 19, 5.0, false),
                new Studentas(5, "Jonas", 20, 7.9, false),
                new Studentas(6, "Tadas", 22, 8.3, true),
            };

            var atfiltruotiStudentai = sarasas.FindAll(studentas => studentas.Id > 5);
            var atfiltruotiStudentai2 = sarasas.FindAll(studentas => studentas.Id > 5);

        }

        private static bool FiltrasPagalId(Studentas studentas)
        {
            return studentas.Id > 5;
        }

        private static void DeegatuPvz()
        {
            List<double> sarasiukas = new List<double> { 1, 2, 3, 4, 5, 6 };
            sarasiukas.Where(x => x > 4);
            var geriMokiniai = sarasiukas.FindAll(x => x.gaunaStipendija);

            MetodasKurisPadaroIskiepintaVeisma(() => Console.WriteLine("Labas pasauli!"));

            MetodasKurisPadaroIskiepintaVeisma2(sk => Console.WriteLine($"Paduoto skaiciaus kvadratas: {sk * sk}"), 9);

            var lyginiusSkaicius = sarasiukas.FindAll(Lyginis);
            var lyginiusSkaicius2 = sarasiukas.FindAll(skacius => skacius % 2 == 0);
        }

        public static void MetodasKurisPadaroIskiepintaVeisma(Action a)
        {
            a();
        }
        public static void MetodasKurisPadaroIskiepintaVeisma2(Action<int> veiksmas, int skaicius)
        {
            veiksmas(skaicius);
        }
        
        public static void MetodasKurisPadaroIskiepintaVeismaIrGrazinaReiksme(Func<int> a)
        {
            int returned = a();
            Console.WriteLine(returned);
        }

        public static void MetodasKurisPadaroIskiepintaVeismaIrGrazinaReiksme2(Func<double, int, > veiksmas, int skaicius)
        {
            veiksmas(skaicius);
        }

        public static bool Lyginis(int skaicius)
        {
            return skaicius % 2 == 0;
        }

        private static void BankoUzd()
        {
            Bankas bankas = new Bankas();
            EmailSender emailSender = new EmailSender();
            bankas.IvykoTransakcija += emailSender.SendMessage;
            bankas.IvykoTransakcija += (s, e) => emailSender.SendMessage(e);

            bool testi = true;
            while (testi)
            {
                Console.WriteLine("Prideti - 1");
                Console.WriteLine("Pervesti - 2");
                Console.WriteLine("Pakeist valiuta - 3");
                Console.WriteLine("Iseiti - 4");
                int pasirinkimas = Convert.ToInt32(Console.ReadLine());
                switch (pasirinkimas)
                {
                    case 1:
                        Console.WriteLine("Kiek?");
                        double money = Convert.ToDouble(Console.ReadLine());
                        bankas.PridetiPinigu(money);
                        break;
                    case 2:
                        Console.WriteLine("Kiek?");
                        double moneyPervesti = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Kur?");
                        string kur = Console.ReadLine();
                        bankas.PervestiPinigu(moneyPervesti, kur);
                        break;
                    default:
                        testi = false;
                        break;
                }
            }
        }

        private static void Suma(int a, int b)
        {
            Console.WriteLine($"Suma: {a + b}");
        }

        private static void Sandauga(int a, int b)
        {
            Console.WriteLine($"Sandauga: {a * b}");
        }

        private void PasakytiKadPasikeiciau()
        {
            OnChanged(this, "pasikeitesTekstas");
            OnChanged?.Invoke(this, "pakeistasTekstas");
        }
    }
}
