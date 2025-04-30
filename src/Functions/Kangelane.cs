using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nik_Kon_Csharp.Functions
{
    public class Kangelane
    {
        private string nimi;
        private string asukoht;

        public string Nimi { get => nimi; set => nimi = value; }
        public string Asukoht { get => asukoht; set => asukoht = value; }

        public Kangelane(string nimi, string asukoht)
        {
            this.nimi = nimi;
            this.asukoht = asukoht;
        }

        public virtual int Paasta(int ohus)
        {
            return (int)Math.Round(ohus * 0.95);
        }

        public virtual string Vormiriietus()
        {
            return $"{Nimi} kannab klassikalist kangelasekostüümi.";
        }

        public virtual string Tervitus()
        {
            return $"Tere, mina olen {Nimi}, teie kaitsja!";
        }

        public virtual string MissiooniStaatus()
        {
            return "Saadaval missiooniks.";
        }

        public override string ToString()
        {
            return $"Kangelane: {Nimi} ({Asukoht})";
        }
    }
}