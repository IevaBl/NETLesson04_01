using System;

/* Paprašyti vartotojo įvesti bet kokį skaičių. 
 * Išvesti visus lyginius skaičius nuo 0 iki pasirinkto skaičiaus, vienoje eilutėje per kablelį. Pvz.: 0, 2, 4, 6..... */

namespace NETLesson04_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite bet kokį skaičių:");
            int number = Int32.Parse(Console.ReadLine());
            int a = 0;

           do
            {
                Console.Write($"{ a = a + 2}, ");
            } 
           while (a<number--);
        }
    }
}
