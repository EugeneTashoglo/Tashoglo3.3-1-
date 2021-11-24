using System;

namespace Tashoglo3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите n:");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите х:");
                double x = double.Parse(Console.ReadLine());
                double S = 0;              
                {                  
                    S += Math.Pow(x - 1, 2) + Math.Pow(x + 1, 4) /2  - Math.Pow(x + 1, 6) / 3;
                }
                Console.WriteLine("S={0:F2}",S);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}


