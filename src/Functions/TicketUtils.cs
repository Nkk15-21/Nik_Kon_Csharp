using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nik_Kon_Csharp.Functions
{
    public static class TicketUtils
    {
        /// <summary>
        /// Проверяет имя и предлагает билет в зависимости от возраста.
        /// </summary>
        public static void CheckTicketByName(string name)
        {
            if (name.Trim().ToLower() != "juku")
            {
                Console.WriteLine("Olen hõivatud!");
                return;
            }

            Console.WriteLine("Lähme kinno!");
            Console.WriteLine($"{name}\nKui vana sa oled?");

            try
            {
                int age = int.Parse(Console.ReadLine());
                if (age <= 0 || age > 100)
                {
                    Console.WriteLine("Viga! Vanus pole sobiv.");
                }
                else if (age <= 6)
                {
                    Console.WriteLine("Tasuta");
                }
                else if (age <= 15)
                {
                    Console.WriteLine("Lastepilet");
                }
                else if (age <= 65)
                {
                    Console.WriteLine("Täispilet!");
                }
                else
                {
                    Console.WriteLine("Sooduspilet!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Vigane sisend: " + e.Message);
            }
        }
    }
}
