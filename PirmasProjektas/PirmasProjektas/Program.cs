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
            int kazkoksSkaicius = 9999 + 1;

            switch (kazkoksSkaicius)
            {
                case int reiksme when reiksme > 0 && reiksme < 100:
                    // KAzkoks kodas kai bus 1
                    break;
                case 2:
                    // KAzkoks kodas
                    break;
                default:
                    // nieko neatitiko
                    break;
            }

            Console.Read();
        }

        private void RastiDidziausia()
        {
            int a = 3;
            int b = 3;
            int c = 1;

            if (a > b && a > c)
            {
                Console.WriteLine("a");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("b");
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("c");
            }
        }
    }
}
