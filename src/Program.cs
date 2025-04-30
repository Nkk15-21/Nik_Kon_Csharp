using System;
using System.Collections.Generic;
using System.Text;
using Nik_Kon_Csharp.Functions;

namespace Nik_Kon_Csharp.src
{
    internal class Program
    {
        //public static void Main(string[] args)
        //{
        //    Console.OutputEncoding = Encoding.UTF8;
        //    Console.WriteLine("Tere! Hea Päev! Привет!");

        //    RunFileOperations();
        //    RunArrayTasks();
        //    RunPersonExamples();
        //    RunBasicInputLogic();

        //    Console.ReadKey();
        //}

        //static void RunFileOperations()
        //{
        //    Console.WriteLine("\n--- Faili töö kuudega ---");
        //    FileUtils.ProcessMonthsFromFile();
        //}

        //static void RunArrayTasks()
        //{
        //    Console.WriteLine("\nRuutude arvutamine (for):");
        //    foreach (var r in ArrayUtils.GetSquares())
        //        Console.WriteLine(r);

        //    Console.WriteLine("\n--------------------------------------------------");


        //    Console.WriteLine("\nKahekordsed väärtused (foreach):");
        //    foreach (var t in ArrayUtils.GetDoubled())
        //        Console.WriteLine(t);

        //    Console.WriteLine("\n--------------------------------------------------");


        //    Console.WriteLine("\nKolmega jaguvad arvud (while):");
        //    Console.WriteLine($"Kokku: {ArrayUtils.CountDivisibleByThree()}");
        //    Console.WriteLine("\n--------------------------------------------------");


        //    Console.WriteLine("\nPositiivsed, negatiivsed ja nullid (foreach):");
        //    ArrayUtils.CountPositiveNegativeZero();
        //    Console.WriteLine("\n--------------------------------------------------");


        //    Console.WriteLine("\n--- Keskmisest suuremad ja do-while osa ---");
        //    ArrayUtils.PrintAboveAverageAndDoWhile();
        //    Console.WriteLine("\n--------------------------------------------------");


        //    Console.WriteLine("\n--- Suurima arvu ja indeksi leidmine ---");
        //    ArrayUtils.FindLargestWithIndex();
        //    Console.WriteLine("\n--------------------------------------------------");


        //    Console.WriteLine("\n--- Paaris ja paaritu loendus ---");
        //    ArrayUtils.CountEvenOdd();
        //    Console.WriteLine("\n--------------------------------------------------");

        //}

        //static void RunPersonExamples()
        //{
        //    List<string> names = TextUtils.ReadWordsFromConsole();
        //    foreach (var name in names)
        //        Console.WriteLine(name);

        //    Console.WriteLine("\n--- Isiku näited ---");

        //    Person person1 = new Person("Juku", 65, "12345678987", "Tallinn");
        //    person1.PrintInfo();

        //    Person person2 = new Person
        //    {
        //        Nimi = "Mari",
        //        Aadress = "Tartu",
        //        Isikukood = "98765432100",
        //        Sugu = Sugu.Naine
        //    };
        //    person2.PrintInfo();

        //    string[] nimed = { "a", "b", "c", "d", "e", "f", "g", "h", "j", "k" };
        //    string[] aadressid = { "Tallinn", "Tartu", "Pärnu", "Narva", "Kohtla", "Jõhvi", "Ahtme", "Rakvere", "Moskva", "Saint-Petersburg" };
        //    Console.WriteLine("\n--------------------------------------------------");


        //    Console.WriteLine("---------- Massiiv isikutega ----------");
        //    var people = PersonUtils.CreatePersons(nimed.Length, nimed, aadressid);
        //    foreach (var p in people)
        //        p.PrintInfo();
        //    Console.WriteLine("\n--------------------------------------------------");


        //    Console.WriteLine("---------- List tagurpidi ----------");
        //    var peopleList = PersonUtils.CreatePersonsReversed(nimed, aadressid);
        //    foreach (var p in peopleList)
        //        p.PrintInfo();
        //    Console.WriteLine("\n--------------------------------------------------");


        //    Console.WriteLine("------ while-loop ------");
        //    int i = nimed.Length;
        //    while (i >= 0)
        //    {
        //        Console.WriteLine(i);
        //        i--;
        //    }
        //    Console.WriteLine("\n--------------------------------------------------");

        //}

        static void RunBasicInputLogic()
        {
            int a;
            string tekst = "Python";
            char taht = 'A';


            // ----------------------------------Проверка tahvel------------------------------------- \\

            // ------------------ 2. osa: Valikute konstruktsioonid ------------------
            Console.WriteLine("=== Valikute konstruktsioonid ===\n");
            ValikuteUtils.RunValikuteNaide();

            Console.WriteLine("\nVajuta Enter jätkamiseks...");
            Console.ReadLine();

            // ------------------ 3. osa: Kordused, massiivid ja klassid ------------------
            Console.WriteLine("\n=== Kordused, massiivid ja klassid ===\n");
            KordusteUtils.RunMassiividJaKordused();

            Console.WriteLine("\nVajuta Enter jätkamiseks...");
            Console.ReadLine();

            // ------------------ 4. osa: Failitöötlus ------------------
            Console.WriteLine("\n=== Failitöötlus ===\n");
            FileUtils.ProcessMonthsFromFile();

            Console.WriteLine("\nVajuta Enter jätkamiseks...");
            Console.ReadLine();

            // ------------------ 5. osa: Kollektsioonid ------------------

            Console.WriteLine("\n=== Kalorite kalkulaator (kollektsioon) ===\n");
            KaloriteUtils.RunKaloriteKalkulaator();

            Console.WriteLine("\nVajuta Enter jätkamiseks...");
            Console.ReadLine();

            Console.WriteLine("\n=== Maakonnad ja linnad (sõnastik) ===\n");
            MaakonnadUtils.RunMaakonnadGame();

            Console.WriteLine("\nVajuta Enter jätkamiseks...");
            Console.ReadLine();

            Console.WriteLine("\n=== Õpilaste hinnete analüüs (listid) ===\n");
            OpilasedUtils.RunOpilasedAnalüüs();

            Console.WriteLine("\nProgrammi lõpp. Vajuta klahvi...");
            Console.ReadKey();
            Console.WriteLine("\n--------------------------------------------------");

            //----------------------------------------------------------------------------------\\

            Console.WriteLine("\n=== Kangelaste agentuur (klassid ja faililugemine) ===\n");
            HeroUtils.Run();

            Console.WriteLine("\nVajuta Enter jätkamiseks...");
            Console.ReadLine();

            Console.WriteLine("\nProgrammi lõpp. Vajuta klahvi...");
            Console.ReadKey();
            Console.WriteLine("\n--------------------------------------------------");

            //-------------------------------------------------------------------------------------\\

            Console.WriteLine("Double arv: ");
            double dValue = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Float arv: ");
            float arv1 = (float)Convert.ToDecimal(Console.ReadLine());

            Console.Write("Mis on sinu nimi? ");
            tekst = Console.ReadLine();
            Console.WriteLine("\n--------------------------------------------------");


            Console.WriteLine($"Tere, {tekst}!");
            TicketUtils.CheckTicketByName(tekst);
            Console.WriteLine("\n--------------------------------------------------");


            Console.Write("Arv 2: ");
            int arv2 = int.Parse(Console.ReadLine());
            float result = MathUtils.Multiply(arv1, arv2);
            Console.WriteLine($"Korrutis: {result}");
            Console.WriteLine("\n--------------------------------------------------");


            Console.WriteLine("Switch'i kasutamine");
            Random rnd = new Random();
            a = rnd.Next(1, 7);
            Console.WriteLine($"Juhuarv: {a}");
            Console.WriteLine($"Päev: {TextUtils.GetDayAbbreviation(a)}");
            Console.WriteLine("\n--------------------------------------------------");



        }
   
    }
}
