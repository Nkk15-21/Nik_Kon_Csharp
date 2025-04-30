using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nik_Kon_Csharp.Functions
{
    public class SuperKangelane : Kangelane
    {
        public double Osavus { get; set; }

        public SuperKangelane(string nimi, string asukoht)
            : base(nimi.Replace("*", "").Trim(), asukoht)
        {
            var rnd = new Random();
            Osavus = Math.Round(1.0 + rnd.NextDouble() * 3.9, 2); // [1.0, 5.0)
        }

        public override int Paasta(int ohus)
        {
            return (int)Math.Round(ohus * (0.95 + Osavus / 100));
        }

        public override string Vormiriietus()
        {
            return $"{Nimi} kannab superkangelase erikostüümi.";
        }

        public override string Tervitus()
        {
            return $"⚡ Mina olen {Nimi} – õiguse kehastus!";
        }

        public override string MissiooniStaatus()
        {
            return "Praegu tegutseb missioonil.";
        }

        public override string ToString()
        {
            return base.ToString() + $" (Super, osavus: {Osavus})";
        }
    }
}
