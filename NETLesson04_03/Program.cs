using System;
using System.Linq;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

/* Vartotojas įveda sakinį, programa išveda visus simbolius atvirkštine tvarka */

namespace NETLesson04_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite sakinį:");
            var sakinys = Console.ReadLine();
            char[] array = sakinys.ToCharArray();
            Array.Reverse(array);
            

            Console.WriteLine(new String(array));            
        }
    }
}
