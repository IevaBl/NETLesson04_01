using System;

/* Parašyti kalkuliatorių. Vartotojas įveda 2 skaičius ir operacijos  simbolį,
 * programa išveda rezultatą ir klausią ar tęsti toliau (taip/ne). Naudoti begalinį ciklą ir break. */

namespace NETLesson04_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite du skaicius ir simboli:");
            var sk1 = Int32.Parse(Console.ReadLine());
            var sk2 = Int32.Parse(Console.ReadLine());
            var sign = Console.ReadLine();


            for (; ; )
            {
                switch (sign)
                {
                    case "+":
                        Console.WriteLine(sk1 + sk2);
                        break;
                    case "-":
                        Console.WriteLine(sk1 - sk2);
                        break;
                    case "*":
                        Console.WriteLine(sk1 * sk2);
                        break;
                    case "/":
                        Console.WriteLine(sk1 / sk2);
                        break;
                    default:
                        break;

                }

                Console.WriteLine("Ar testi toliau Y/N");
                var ans = Console.ReadLine();
                if (ans == "Y")
                {
                    continue;
                }
                else
                    break;
            }

        }
    }
}
