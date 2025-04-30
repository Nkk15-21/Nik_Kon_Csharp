using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nik_Kon_Csharp.Functions
{
    public class Opilane
    {
        public string Nimi { get; set; }
        public List<int> Hinded { get; set; } = new();
        public double Keskmine => Hinded.Count > 0 ? Hinded.Average() : 0;
    }

    public static class OpilasedUtils
    {
        public static void RunOpilasedAnalüüs()
        {
            var opilased = new List<Opilane>
            {
                new Opilane { Nimi = "Mari", Hinded = new List<int> { 5, 4, 3, 5 } },
                new Opilane { Nimi = "Juku", Hinded = new List<int> { 2, 3, 2 } },
                new Opilane { Nimi = "Kati", Hinded = new List<int> { 4, 5, 5, 4, 5 } }
            };

            Console.WriteLine("Õpilaste keskmised hinded:");
            foreach (var o in opilased)
                Console.WriteLine($"{o.Nimi}: {o.Keskmine:F2}");

            var parim = opilased.OrderByDescending(o => o.Keskmine).First();
            Console.WriteLine($"\nParim õpilane: {parim.Nimi} ({parim.Keskmine:F2})");

            Console.WriteLine("\nÕpilased sorditult:");
            foreach (var o in opilased.OrderByDescending(o => o.Keskmine))
                Console.WriteLine($"{o.Nimi}: {o.Keskmine:F2}");
        }
    }
}
