using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ConsoleKeyInfo keyInfo;

                Console.WriteLine("Enter didgit from 100 to 999 and press Enter for convert: ");
                string s = Console.ReadLine();
                if (Int32.TryParse(s, out int rez))
                {
                    if (rez < 100)
                    {
                        Console.WriteLine("Enter number more then 99 ");
                    }
                    else if (rez > 999)
                    {
                        Console.WriteLine("Enter number less then 1000 ");
                    }
                    else
                    {
                        // реализация

                    }
                }
                else
                {
                    Console.WriteLine("This is not a number. Enter number ");
                }








                Console.WriteLine("for exit press Escape / for continue press any button: ");
                keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.Spacebar)
                {
                    break;
                }
            }
        }
    }
}
