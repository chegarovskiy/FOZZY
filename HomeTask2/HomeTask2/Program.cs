using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask2
{
    class Program
    {
        public static bool Validation(string n, string p, Dictionary<string, string> d)
        {
            bool rez = (d.ContainsKey(n) | d.ContainsValue(p)) ? true : false;         
            return rez;
        }
        static void Main(string[] args)
        {
            Dictionary<string, string> users = new Dictionary<string, string>();
            Dictionary<string, decimal> monthProfit = new Dictionary<string, decimal>(4);
            List<string> numbersMonth = new List<string> { "first", "second", "third", "fourth" };

            Console.WriteLine("Enter you name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter you password:");
            string pass = Console.ReadLine();
            users.Add(name, pass);

            while (true)
            {
                ConsoleKeyInfo keyInfo;
                foreach (string item in numbersMonth)
                {
                    try
                    {
                        Console.WriteLine("Enter " + item + " month :");
                        string month = Console.ReadLine();
                        if (!monthProfit.Keys.Contains(month))
                        {
                            Console.WriteLine("Enter profit for " + month + " :");
                            string profit = Console.ReadLine();
                            monthProfit.Add(month, Convert.ToDecimal(profit));
                        }
                        else
                        {
                            Console.WriteLine("month should not be repeated");
                            break;
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("invalid data");
                    }
                }

                try
                {
                    Console.WriteLine("Confirm you name:");
                    string n = Console.ReadLine();
                    Console.WriteLine("Confirm you password:");
                    string p = Console.ReadLine();

                    if (Validation(n, p, users))
                    {
                        var items = from pair in monthProfit orderby pair.Value select pair;
                        Console.WriteLine("sorted data:");
                        foreach (var it in items)
                        {
                            Console.WriteLine(it.Key + " : " + it.Value);
                        }
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("name or password incorrect");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("invalid name or password");
                }
                Console.WriteLine("for exit press Spasebar / for continue press any button: ");
                keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.Spacebar)
                {
                    break;
                }
            }
        }
    }
}
