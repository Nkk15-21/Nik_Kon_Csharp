using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Nik_Kon_Csharp
{
    public enum Sugu
    {
        Mees,
        Naine
    }

    public class Person
    {
        public string Nimi { get; set; }
        public int Vanus { get; set; }
        public string Isikukood { get; set; }
        public string Aadress { get; set; }
        public Sugu Sugu { get; set; } = Sugu.Mees;

        public Person() { }

        public Person(string nimi, int vanus, string isikukood, string aadress)
        {
            Nimi = nimi;
            Vanus = vanus;
            Isikukood = isikukood;
            Aadress = aadress;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Nimi: {Nimi}, Vanus: {Vanus}, Sugu: {Sugu}, Isikukood: {Isikukood}, Aadress: {Aadress}\n");
        }
    }
}
