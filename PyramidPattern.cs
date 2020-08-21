using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternTask
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().PrintChar();
            Console.ReadKey();
        }
        public void PrintChar()
        {
            Console.WriteLine("Enter Number You want to Print");
            int InputNum = Convert.ToInt32(Console.ReadLine());
            int z = 1;
            int i = 1;
            int m = 1;
            if (1 <= InputNum && InputNum <= 26)
            {
                for (i = 1; i <= InputNum; i++)
                {
                    for (int j = InputNum; j >= i; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= z; k++)
                    {
                        Console.Write((char)(90 - Math.Abs(i - k)));
                    }
                    z += 2;
                    Console.WriteLine();
                }
                m = 1;
                int count = InputNum + InputNum - 2;
                for (int j = InputNum; j >= m; j--)
                {
                    for (i = InputNum + 1; i >= j; i--)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k < count; k++)
                    {
                        Console.Write((char)(90 - Math.Abs(i - k)));
                    }
                    count -= 2;
                    Console.WriteLine();
                }
            }
            else
            {
                Console.Write("Please Enter Number between 1 to 26");
            }
        }
    }
}
