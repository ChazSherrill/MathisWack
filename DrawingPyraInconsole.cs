using System;

namespace Continuing_with_Solo_Learn
{
    class Program
    {
        static void DrawPyramid(int n)
        {
            for (int i = 1; i<=n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    Console.Write("  ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*"+" ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            DrawPyramid(10);
        }
    }
}
//making a pyramid