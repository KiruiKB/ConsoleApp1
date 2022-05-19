using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    Console.Write("*");
                }
                num++;
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
