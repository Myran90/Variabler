using System;

namespace övning1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Summan av två tal
            Skapa ett program där man matar in två tal, sedan lägger programmet ihop dessa tal.
            */
            Console.Write("Mata in ett tal: ");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mata in ett tal: ");
            int tal2 = Convert.ToInt32(Console.ReadLine());
            int sum = tal1+tal2;

            Console.WriteLine("Ditt tal blir: "+ sum);

        }
    }
}
