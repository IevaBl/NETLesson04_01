using System;

/* Nupiešti piramidę iš pasirinkto eilučių kiekio */

namespace NETLesson04_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 0; i < 10; i++) /*kiek bus eiluciu*/
            {
                for (j = 1; j <= 10 - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
        }
    }
}
