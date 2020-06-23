using System;

namespace Euler_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a;
            //int b;
            double c;
            for (int a = 1; a < 300; a++)
                for(int b = 2; b < 400; b++)
                {
                    if(Math.Sqrt(a*a+b*b)%1 == 0)
                    {
                        c = Math.Sqrt((a * a) + (b * b));
                        if((a+b+c)== 1000)
                            Console.WriteLine($"a = {a}, b = {b}, c = {c}");
                        // a = 200, b = 375, c = 425
                    }
                }
        }
    }
}
