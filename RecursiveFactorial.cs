using System;

namespace My_Second_Csharp_Program
{
    class Program
    {
        static int Fact(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            return num * Fact(num - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Fact(10));
        }
    }
}
