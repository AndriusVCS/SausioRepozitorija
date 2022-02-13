using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndStuff
{
    class ManoKitaKlase
    {
        public ManoKlase KlasesObjektas { get; private set; }
        public void NustatytiManoKlase(ManoKlase klasesObjektas)
        {
            KlasesObjektas = klasesObjektas;
        }
    }
}
