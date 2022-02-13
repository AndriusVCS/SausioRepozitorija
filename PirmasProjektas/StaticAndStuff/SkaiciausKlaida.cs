using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndStuff
{
    class SkaiciausKlaida : Exception
    {
        public SkaiciausKlaida() : base("Skaicius negali buti neigiamas!")
        {

        }
    }
}
