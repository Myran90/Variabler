using System;

namespace övning4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Char
            Prova att använda olika numeriska värden i UNICODE-tabellen. Vilka slutsatser kan du dra av detta? */
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("\u2721");
            // Jag drar slutsatsen för att få UNICODE att fungera på c#, så måste du lägga till en Encoder för Unicorn.
        }
    }
}
