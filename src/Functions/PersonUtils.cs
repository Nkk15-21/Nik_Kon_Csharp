using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nik_Kon_Csharp; // ← ОБЯЗАТЕЛЬНО, иначе Person будет "не найден"

namespace Nik_Kon_Csharp.Functions
{
    public static class PersonUtils
    {
        /// <summary>
        /// Создаёт массив объектов Person из массивов имён и адресов.
        /// </summary>
        public static Person[] CreatePersons(int count, string[] names, string[] addresses)
        {
            Person[] people = new Person[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(i);
                people[i] = new Person
                {
                    Nimi = names[i],
                    Vanus = i + 10,
                    Isikukood = Console.ReadLine(),
                    Aadress = addresses[i]
                };
            }

            return people;
        }

        /// <summary>
        /// Создаёт список объектов Person в обратном порядке из имён и адресов.
        /// </summary>
        public static List<Person> CreatePersonsReversed(string[] names, string[] addresses)
        {
            List<Person> people = new List<Person>();

            for (int j = names.Length - 1; j >= 0; j--)
            {
                Console.WriteLine(j);
                Person person = new Person
                {
                    Nimi = names[j],
                    Vanus = j + 10,
                    Isikukood = "12345678950",
                    Aadress = addresses[j]
                };
                people.Add(person);
            }

            return people;
        }
    }
}