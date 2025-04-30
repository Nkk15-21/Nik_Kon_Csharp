using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nik_Kon_Csharp.Functions
{
    public static class FileUtils
    {
        private static readonly string FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "months.txt");

        public static void ProcessMonthsFromFile()
        {
            EnsureFileDirectoryExists();

            if (!File.Exists(FilePath))
            {
                File.WriteAllLines(FilePath, new[] { "Mai", "Juuni", "Juuli" });
                Console.WriteLine("Esimesed kuud kirjutatud faili.");
            }

            List<string> months = new List<string>();
            try
            {
                months.AddRange(File.ReadAllLines(FilePath));
            }
            catch (Exception)
            {
                Console.WriteLine("Viga failiga!");
                return;
            }

            months.Remove("Juuni");

            if (months.Count > 0)
                months[0] = "Veeel kuuu";

            Console.WriteLine("-------------- Kuud peale muutmist -----------");
            foreach (string kuu in months)
            {
                Console.WriteLine(kuu);
            }

            Console.Write("Sisesta kuu nimi, mida otsida: ");
            string search = Console.ReadLine();

            if (months.Contains(search))
                Console.WriteLine($"Kuu {search} on olemas.");
            else
                Console.WriteLine("Sellist kuud pole.");

            File.WriteAllLines(FilePath, months);
            Console.WriteLine("Andmed on salvestatud.");
        }

        private static void EnsureFileDirectoryExists()
        {
            string dir = Path.GetDirectoryName(FilePath);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }
    }
}
