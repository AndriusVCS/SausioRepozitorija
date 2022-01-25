namespace Paveldimumas
{
    class Korta
    {
        public string Pavadinimas { get; }
        public int Verte { get; }
        public string Zenklas { get; }

        public Korta(string pavadinimas, int verte, string zenklas)
        {
            Pavadinimas = pavadinimas;
            Verte = verte;
            Zenklas = zenklas;
        }
    }
}
