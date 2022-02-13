using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatai
{
    public class Bankas
    {
        public event EventHandler<string> PridejoPinigu;
        public event EventHandler<string> PervedePinigu;
        public event EventHandler<string> PakeitePiniguValiuta;
        public event EventHandler<string> IvykoTransakcija;

        public void PridetiPinigu(double money)
        {
            string zinute = $"Pridejo {money}!";
            IvykoTransakcija?.Invoke(this, zinute);
            PridejoPinigu?.Invoke(this, zinute);
        }
        
        public void PervestiPinigu(double money, string saskaitosNr)
        {
            string zinute = $"Pervede {money} i {saskaitosNr}!";
            IvykoTransakcija?.Invoke(this, zinute);
            PervedePinigu?.Invoke(this, zinute);
        }

        public void PakeistiValiuta(double money, string valiuta)
        {
            string zinute = $"Pakeite valiuta {money} {valiuta}!";
            IvykoTransakcija?.Invoke(this, zinute);
            PakeitePiniguValiuta?.Invoke(this, zinute);
        }

        public override string ToString()
        {
            return "Bankas";
        }

    }
}
