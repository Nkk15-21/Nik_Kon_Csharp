using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nik_Kon_Csharp.Functions
{
    public class Toode
    {
        public string Nimi { get; set; }
        public double Kalorid100g { get; set; }
    }

    public class Inimene
    {
        public string Nimi { get; set; }
        public int Vanus { get; set; }
        public string Sugu { get; set; } // "mees" või "naine"
        public double Pikkus { get; set; } // cm
        public double Kaal { get; set; }   // kg
        public double Aktiivsus { get; set; } // koefitsient

        public double ArvutaPäevaneKaloreid()
        {
            // Harris-Benedicti valem
            double baas = Sugu.ToLower() == "mees"
                ? 66.5 + 13.75 * Kaal + 5.003 * Pikkus - 6.755 * Vanus
                : 655.1 + 9.563 * Kaal + 1.850 * Pikkus - 4.676 * Vanus;

            return baas * Aktiivsus;
        }
    }

    public static class KaloriteUtils
    {
        public static void RunKaloriteKalkulaator()
        {
            // Näidisandmed
            var toidud = new List<Toode>
            {
                new Toode { Nimi = "Õun", Kalorid100g = 52 },
                new Toode { Nimi = "Riis", Kalorid100g = 130 },
                new Toode { Nimi = "Kanafilee", Kalorid100g = 165 }
            };

            // Kasutaja sisestus
            var inimene = new Inimene();
            Console.Write("Nimi: "); inimene.Nimi = Console.ReadLine();
            Console.Write("Vanus: "); inimene.Vanus = int.Parse(Console.ReadLine());
            Console.Write("Sugu (mees/naine): "); inimene.Sugu = Console.ReadLine();
            Console.Write("Pikkus (cm): "); inimene.Pikkus = double.Parse(Console.ReadLine());
            Console.Write("Kaal (kg): "); inimene.Kaal = double.Parse(Console.ReadLine());
            Console.Write("Aktiivsus (nt 1.2 - istuv, 1.55 - keskmine, 1.9 - aktiivne): ");
            inimene.Aktiivsus = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // для запятой


            double vajadus = inimene.ArvutaPäevaneKaloreid();
            Console.WriteLine($"\n{inimene.Nimi}, sinu päevane energiavajadus on: {vajadus:F1} kcal");

            Console.WriteLine("\nSoovitatav päevane kogus toitu (grammides):");
            foreach (var t in toidud)
            {
                double kogus = vajadus / t.Kalorid100g * 100;
                Console.WriteLine($"{t.Nimi}: {kogus:F0} g");
            }
        }
    }
}
