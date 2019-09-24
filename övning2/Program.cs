using System;

namespace övning2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Decimal till heltal
            Skapa ett program som omvandlar ett inmatat decimaltal till närmaste heltal.*/
            Console.Write("Skriv in ett decimaltal: ");
            decimal dec = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Avrundat tal: "+Math.Round(dec));
        }
    }
}
