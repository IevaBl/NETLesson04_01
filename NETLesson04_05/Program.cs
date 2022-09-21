using System;
using System.Runtime.CompilerServices;

/* Išvesti skaičių sumą nuo 1 iki pasirinkto didelio skaičiaus. Parodyti skaičiavimo progresą */

namespace NETLesson04_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite bet koki dideli skaiciu:");
            var input = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("Jums bus rodomas skaiciavimo progresas!");

            do
            {
                for (int i = 0; i <= 100; i++)
                {
                    Console.WriteLine($"{i}%");
                }
            }
            while (input != input);
        }
    }
}
