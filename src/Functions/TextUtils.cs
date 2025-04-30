using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nik_Kon_Csharp.Functions
{
    public static class TextUtils
    {
        /// <summary>
        /// Запрашивает у пользователя 5 имён и возвращает их в списке.
        /// </summary>
        public static List<string> ReadWordsFromConsole()
        {
            List<string> words = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Nimi: ");
                words.Add(Console.ReadLine());
            }
            return words;
        }

        /// <summary>
        /// Возвращает сокращённое название дня недели по номеру (1–7).
        /// </summary>
        public static string GetDayAbbreviation(int number)
        {
            return number switch
            {
                1 => "E", // Esmaspäev
                2 => "T", // Teisipäev
                3 => "K", // Kolmapäev
                4 => "N", // Neljapäev
                5 => "R", // Reede
                6 => "L", // Laupäev
                7 => "P", // Pühapäev
                _ => "Tundmatu"
            };
        }
    }
}
