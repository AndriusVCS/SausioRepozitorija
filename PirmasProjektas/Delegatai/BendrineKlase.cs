using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatai
{
    public class TevineKlase
    {
        public void Print(string s)
        {
            Console.WriteLine(s);
        }
    }

    public class VaikoKlase : TevineKlase
    {

    }

    class BendrineKlase<T> where T : TevineKlase
    {
        private T _bendrinisKintamasis;

        public BendrineKlase()
        {
            
            _bendrinisKintamasis.Print("Labas!");
        }
    }

    interface IPrintInfo<T> where T : new()
    {
        void PrintInfo();
    }

    class BendrineKlase1
    {
        private TevineKlase _bendrinisKintamasis;

        public BendrineKlase1()
        {
            _bendrinisKintamasis.Print("Labas!");
        }
    }
    class BendrineKlase2
    {
        private VaikoKlase _bendrinisKintamasis;

        public BendrineKlase2()
        {
            _bendrinisKintamasis.Print("Labas!");
        }
    }
}
