namespace Delegatai
{
    class Studentas
    {
        public int Id { get; }
        public string Vardas { get; }
        public int Amzius { get; }
        public double Vidurkis { get; }
        public bool GaunaStipendija { get; }

        public Studentas(int id, string vardas, int amzius, double vidurkis, bool gaunaStipendija)
        {
            Id = id;
            Vardas = vardas;
            Amzius = amzius;
            Vidurkis = vidurkis;
            GaunaStipendija = gaunaStipendija;
        }
    }
}
