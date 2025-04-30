using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nik_Kon_Csharp.Functions
{
    public static class ValikuteUtils
    {
        public static void RunValikuteNaide()
        {
            Console.Write("Sisesta vanus: ");
            if (int.TryParse(Console.ReadLine(), out int vanus))
            {
                if (vanus < 7)
                    Console.WriteLine("Tasuta pilet");
                else if (vanus <= 15)
                    Console.WriteLine("Lastepilet");
                else if (vanus <= 65)
                    Console.WriteLine("Täispilet");
                else
                    Console.WriteLine("Sooduspilet");

                Console.Write("\nSisesta nädalapäeva number (1-7): ");
                if (int.TryParse(Console.ReadLine(), out int päev))
                {
                    switch (päev)
                    {
                        case 1: Console.WriteLine("Esmaspäev"); break;
                        case 2: Console.WriteLine("Teisipäev"); break;
                        case 3: Console.WriteLine("Kolmapäev"); break;
                        case 4: Console.WriteLine("Neljapäev"); break;
                        case 5: Console.WriteLine("Reede"); break;
                        case 6: Console.WriteLine("Laupäev"); break;
                        case 7: Console.WriteLine("Pühapäev"); break;
                        default: Console.WriteLine("Tundmatu päev"); break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Viga: sisestus polnud number.");
            }
        }
    }
}
