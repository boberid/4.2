using System;

namespace _4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2
            Console.WriteLine("N = ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[N];
            double a = 2;
            for (int i = 1; i <= N; i++)
            {
                double y = Math.Pow(a, i);
                Console.WriteLine(i + "\t" + y);
            }
        }
    }
}
