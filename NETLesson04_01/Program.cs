using System;

//Paprašyti vartotojo įvesti bet kokį skaičių.
//Išvesti skaičių sumą nuo 1 iki įvesto skaičiaus.

namespace NETLesson04_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite bet kokį skaičių:");
            int number = Int32.Parse(Console.ReadLine()); //konvertuoju i int
            int holder = 0; // sukuriu kintamaji nuo kurio prades skaiciuoti

            for(int i = 0; i <= number; i++) //apibreziu iki kokio skaiciaus vyks ciklas, siuo atveju iki ivestojo
            {
                holder = holder + i; //didiname per vieneta o holder laiko paskutine reiksme                
            }
            Console.WriteLine(holder); //isvedame suma
            
        }
    }
}
