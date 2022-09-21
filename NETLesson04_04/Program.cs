using System;

/* Paprašyti įvesti skaičių. Parodyti pasirinkto skaičiaus daugybos lentelę. 
 * Paklausti ar tęsti (taip/ne)Naudoti begalinį ciklą, ciklą cikle ir break. */

namespace NETLesson04_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(; ; )
            {
                Console.WriteLine("Iveskite bet kokį skaičių:");
                int sk = Int32.Parse(Console.ReadLine());

                for(int i = 0; i <= 10; i++)
                {
                    Console.WriteLine($"{sk}*{i} = {sk*i}");
                }
                Console.WriteLine("Ar testit toliau? (taip/ne)");
                var ats = Console.ReadLine();
                if (ats == "ne")
                {
                    break;
                }

            }
            
        }
    }
}
