using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndStuff
{
    class WordsDatabase
    {
        private List<string> _zodziai = new List<string>();

        public bool Prideti(string zodis)
        {
            if (_zodziai.Contains(zodis))
            {
                Console.WriteLine("Duplikatas!");
                return false;
            }
            else
            {
                _zodziai.Add(zodis);
                Console.WriteLine($"Zodis \"{zodis}\" issaugotas!");
                return true;
            }
        }
    }
}
