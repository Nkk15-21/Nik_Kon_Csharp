using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nik_Kon_Csharp.Functions
{
    public static class KordusteUtils
    {
        public static void RunMassiividJaKordused()
        {
            int[] arvud = { 1, 2, 3, 4, 5 };

            Console.WriteLine("FOR-loop:");
            for (int i = 0; i < arvud.Length; i++)
            {
                Console.Write(arvud[i] + " ");
            }

            Console.WriteLine("\nFOREACH-loop:");
            foreach (var arv in arvud)
            {
                Console.Write(arv + " ");
            }

            Console.WriteLine("\nWHILE-loop:");
            int j = 0;
            while (j < arvud.Length)
            {
                Console.Write(arvud[j] + " ");
                j++;
            }

            Console.WriteLine("\nDO-WHILE-loop:");
            int k = 0;
            do
            {
                Console.Write(arvud[k] + " ");
                k++;
            } while (k < arvud.Length);
        }
    }
}
