using System;
namespace Uppgift_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut gymnasiet? (j/n)");
            string gymnasiet = Console.ReadLine().ToLower();
            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());

            if (gymnasiet == "j" && ålder < 22)
            {
                Console.WriteLine("Vi vill anställa dig!");
            }
            else
            {
                Console.WriteLine("Vi vill anställa en annan personal just nu.");
            }
        }
    }
}