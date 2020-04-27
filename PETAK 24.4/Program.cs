using System;

namespace PETAK_24._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int god;
            god = Convert.ToInt32(Console.ReadLine());

            if (god % 400 == 0)
            {
                Console.WriteLine("godina je prijestupna");
            }
            else if (god % 100 == 0)
            {
                Console.WriteLine("godina nije prijestupna");
            }
            else if (god % 4 == 0)
            {
                Console.WriteLine("godina je prijestupna");
            }
            else
            {
                Console.WriteLine("godina nije prijestupna");
            }
            Console.ReadKey();

        }
    }
}
 ---  int a;

            try
            {
                a = int.Parse(Console.ReadLine());
Console.WriteLine("unio si radijus " +
                    a +
                    "," +
                    "povrsina" +
                    (a* a * Math.PI) +
                    "a opseg je " +
                    (2 * a * Math.PI);


            }

        catch(FormatException fex)
            {
                Console.WriteLine("nisi unio broj" + "\n" + fex.ToString());


            }
            catch (Exception ex)
            {
                Console.WriteLine("Generalna greska" + ex.Message + "\n" + ex.ToString());
            }
    ---
    double pi, P, O, r;
pi = Math.PI;
            Console.WriteLine("upisi radius kruga");
            r = Convert.ToDouble(Console.ReadLine());
            P = r* r * pi;
O = 2 * r * pi;
Console.WriteLine("povrsina je" + P + "a opseg je " + O);
            Console.ReadKey();
    ---
    Double a, b, c, d, R;
Console.WriteLine("upiši 2 broja");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = a % 3;
            d = b % 3;
            R = c + d;
            Console.WriteLine(R);
            Console.ReadKey();

