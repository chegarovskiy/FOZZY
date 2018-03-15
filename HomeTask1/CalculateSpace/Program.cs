using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            ConsoleKeyInfo keyInfo;         
            int count = 0;
            Console.WriteLine("Enter somesing:");
            while (true)
            {             
                keyInfo = Console.ReadKey();
                if (keyInfo.KeyChar == ' ')
                {
                    count++;
                }             
                if (keyInfo.KeyChar == '.')
                {
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("number of spaces is: {0}", count);
            Console.ReadKey();
        }
    }
}
