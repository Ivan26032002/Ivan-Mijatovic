using System;

namespace Zbrajanje_2_broja
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite prvi broj!");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite drugi broj!");
            int b = int.Parse(Console.ReadLine());
            int c = a + b;
            Console.WriteLine(c);



        }
    }
}
