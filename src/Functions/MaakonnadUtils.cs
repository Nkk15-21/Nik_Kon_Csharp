using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nik_Kon_Csharp.Functions
{
    public static class MaakonnadUtils
    {
        public static void RunMaakonnadGame()
        {
            var maakonnad = new Dictionary<string, string>
            {
                { "Harjumaa", "Tallinn" },
                { "Tartumaa", "Tartu" },
                { "Pärnumaa", "Pärnu" },
                { "Ida-Virumaa", "Jõhvi" }
            };

            while (true)
            {
                Console.Write("\nSisesta maakond või pealinn (või 'exit'): ");
                string sisend = Console.ReadLine();
                if (sisend == "exit") break;

                bool leitud = false;

                // Otsime maakonna järgi
                if (maakonnad.TryGetValue(sisend, out var linn))
                {
                    Console.WriteLine($"Pealinn: {linn}");
                    leitud = true;
                }
                else
                {
                    // Otsime linna järgi
                    foreach (var paar in maakonnad)
                    {
                        if (paar.Value.Equals(sisend, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine($"Maakond: {paar.Key}");
                            leitud = true;
                            break;
                        }
                    }
                }

                if (!leitud)
                {
                    Console.WriteLine("Ei leitud. Lisa uus kirje!");
                    Console.Write("Maakond: ");
                    string maakond = Console.ReadLine();
                    Console.Write("Pealinn: ");
                    string pealinn = Console.ReadLine();
                    maakonnad[maakond] = pealinn;
                }
            }

            // Testimäng
            int punktid = 0;
            var rnd = new Random();
            var keys = new List<string>(maakonnad.Keys);

            for (int i = 0; i < 3; i++)
            {
                string valik = keys[rnd.Next(keys.Count)];
                Console.Write($"Mis on maakonna {valik} pealinn? ");
                string vastus = Console.ReadLine();

                if (vastus.Equals(maakonnad[valik], StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Õige!");
                    punktid++;
                }
                else
                {
                    Console.WriteLine($"Vale! Õige vastus oli {maakonnad[valik]}.");
                }
            }

            Console.WriteLine($"\nTulemus: {punktid}/3 ({punktid * 100 / 3}%)");
        }
    }
}
