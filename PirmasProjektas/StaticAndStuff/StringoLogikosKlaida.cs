using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndStuff
{
    class StringoLogikosKlaida : Exception
    {
        public StringoLogikosKlaida() : base("Stringas neatitinka taisykliu!")
        {

        }
    }
}
