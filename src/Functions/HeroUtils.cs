using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Nik_Kon_Csharp.Functions
{
    public static class HeroUtils
    {
        public static List<Kangelane> kangelased = new();

        public static void LoeKangelasedFailist(string failinimi)
        {
            if (!File.Exists(failinimi))
            {
                Console.WriteLine("Fail puudub: " + failinimi);
                return;
            }

            foreach (var rida in File.ReadAllLines(failinimi))
            {
                var osad = rida.Split('/');
                if (osad.Length != 2) continue;

                string nimi = osad[0].Trim();
                string asukoht = osad[1].Trim();

                if (nimi.Contains("*"))
                    kangelased.Add(new SuperKangelane(nimi, asukoht));
                else
                    kangelased.Add(new Kangelane(nimi, asukoht));
            }
        }

        public static void Run()
        {
            LoeKangelasedFailist(Path.Combine("data", "andmed.txt"));

            var tavaline = kangelased.FirstOrDefault(k => k is Kangelane && k.GetType() == typeof(Kangelane));
            var super = kangelased.FirstOrDefault(k => k is SuperKangelane);

            if (tavaline != null)
            {
                Console.WriteLine("\n--- Tavaline kangelane ---");
                Console.WriteLine(tavaline);
                Console.WriteLine(tavaline.Tervitus());
                Console.WriteLine(tavaline.Vormiriietus());
                Console.WriteLine(tavaline.MissiooniStaatus());
                Console.WriteLine($"Päästetud: {tavaline.Paasta(1000)} inimest");
            }

            if (super != null)
            {
                Console.WriteLine("\n--- Superkangelane ---");
                Console.WriteLine(super);
                Console.WriteLine(super.Tervitus());
                Console.WriteLine(super.Vormiriietus());
                Console.WriteLine(super.MissiooniStaatus());
                Console.WriteLine($"Päästetud: {super.Paasta(1000)} inimest");
            }
        }
    }
}
