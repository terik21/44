using System;
namespace pc
{
    class Programm
    {
        static void Main()
        {
            int i = int.Parse(Console.ReadLine());
            table(i);
        }
        static void table(int x)
        {
            Console.Write("  ");
            int a = 1;
            while (a <= x)
            {
                Console.Write($"{a} ");
                a++;
            }
            Console.WriteLine();
            a = 0;
            for (int i = 1; i <= x; i++)
            {
                Console.Write($"{i} ");
                for (int j = 1; j <= x; j++)
                {
                    Console.Write($"{i*j} ");
                }
                Console.WriteLine();
            }


        }
    }
}