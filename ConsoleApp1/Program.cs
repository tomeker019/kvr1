using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main()
        {
            int a, b, c;

            double d, x1, x2;
            Console.Write("Výpočet kvadratické rovnice\n");

            Console.Write("Zadej a : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Zadej b : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Zadej c : ");
            c = Convert.ToInt32(Console.ReadLine());

            d = b * b - 4 * a * c;
            if (d == 0)
            {
                Console.Write("Obě x mají stejnou hodnotu.\n");
                x1 = -b / (2.0 * a);
                x2 = x1;
                Console.Write("x1 = {0}\n", x1);
                Console.Write("x2 = {0}\n", x2);
            }
            else if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);

                Console.Write("x1 = {0}\n", x1);
                Console.Write("x2 = {0}\n", x2);
            }
            else
                Console.Write("Nemá řešení.");
        }
    }
}
