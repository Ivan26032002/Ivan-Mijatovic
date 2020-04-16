
using System;

namespace skola
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("upisi do koliko zelis ici");
            n = Convert.ToInt32(Console.ReadLine());

            for ( int i = 1 ;i <= n; i++) 
            
                {if ( (i % 4 == 3) || (i % 4 == 0))
                


                    Console.WriteLine(i + " ");
                




                }




        }
        
}
}

...
int i;
            for (i = 1;i <= 100; i++) 
            
                {
                if (i % 5 == 0)
                    Console.WriteLine(i + " ");



                }
...
    for (i = 1;i <= 10; i++)
    console.writeline(i + " ");
