using System;

namespace övning5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*I denna övning ska du göra ett program som låter användaren mata in sitt namn. 
            Därefter hälsar du användaren välkommen. Du ska sedan låta användaren mata in sin
            ålder och spara undan den i lämplig variabel. Räkna sedan ut antalet dagar användaren
            har levt utifrån det angivna åldern. Presentera detta för användaren. */
            Console.Write("Skriv in ditt namn: ");
            string namn = Console.ReadLine();
            Console.WriteLine("Hej och välkommen "+namn);
            Console.Write("Skriv nu in din ålder: ");
            int ålder = Convert.ToInt32(Console.ReadLine());
            Console.Write("Du är "+ålder*365+" dagar gammal");

        }
    }
}
