using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klases
{
    class Medis
    {
        public int SakuSkaicius { get; private set; }

        public Medis()
        {
            SakuSkaicius = 0;
        }

        public void Augti()
        {
            SakuSkaicius++;
        }
    }
}
