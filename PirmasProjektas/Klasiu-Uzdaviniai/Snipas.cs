using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasiu_Uzdaviniai
{
    class Snipas
    {
        public string Vardas { get; private set; }
        public int InfiltracijuKiekis { get; private set; }

        public Snipas(string vardas)
        {
            Vardas = vardas;
            InfiltracijuKiekis = 0;
        }

        public void Infiltruotis()
        {
            InfiltracijuKiekis++;
        }
    }
}
