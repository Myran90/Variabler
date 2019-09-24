using System;

namespace övning3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Saga med två sträng variabler
            Låt användaren mata in två namn. Skriv sedan ut en kort berättelse med dessa två namn.*/
            Console.Write("Skriv in ett namn: ");
            string namnEtt = Console.ReadLine();
            Console.Write("Skriv in ett namn: ");
            string namnTvå = Console.ReadLine();

            Console.Write("Sagan om "+namnEtt+" och "+namnTvå);
        }
    }
}
