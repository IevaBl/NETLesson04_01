using System;

/* Parašyti programą, kuri sukeičia žodžius sakinyje nuo galo iki pradžios. */

namespace NETLesson04_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sakinys = "As su mama einu pirkti ledu";
            string[] words = sakinys.Split(' ');
            Array.Reverse(words);

            Console.WriteLine(string.Join(" ", words));
        }
    }
}
