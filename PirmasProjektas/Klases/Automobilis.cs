namespace Klases
{
    class Automobilis
    {
        public string Marke;
        public string Modelis;
        public int Metai;
        public double Turis;

        public Automobilis()
        {

        }

        public Automobilis(string marke, string modelis, int metai, double turis)
        {
            Marke = marke;
            Modelis = modelis;
            Metai = metai;
            Turis = turis;
        }

        public void Vaziuoti()
        {
            System.Console.WriteLine("Vaziuoju!");
        }

        private void Sustoti()
        {
            System.Console.WriteLine("Sustoju!");
        }
    }
}
