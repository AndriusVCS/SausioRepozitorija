using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndStuff
{
    public static class SarasuPletiniai
    {
        public static void ManoParasytasMetodas(this string kazkoksSarasas)
        {
            Console.WriteLine($"Mano metodas! Sitam stringe: {kazkoksSarasas.Length} raidziu!");
            Console.ReadLine();
        }
    }
}
