using System;

namespace HomeTask1
{
    public class Program : Didgitals
    {

        static void Main(string[] args)
        {
            
            while (true)
            {
                Didgitals didgitals = new Didgitals();
                ConsoleKeyInfo keyInfo;
                while (true)
                {
                   
                    Console.WriteLine("Enter fest didgital and press Enter: ");
                    string s = Console.ReadLine();
                    if (int.TryParse(s, out int nInt))
                    {
                        didgitals.typeFirstDidgit = nInt.GetType();
                        didgitals.firstDidgit = (int)nInt;
                        break;
                    }
                    else if (double.TryParse(s, out double nDouble))
                    {
                        didgitals.typeFirstDidgit = nDouble.GetType();
                        didgitals.firstDidgit = (double)nDouble;
                        break;
                    }         
                    else
                    {
                        Console.WriteLine("Not a didgit!");                      
                    }
                }

                while (true)
                {
                    Console.WriteLine("Enter second didgital and press Enter: ");
                    string s = Console.ReadLine();
                    if (int.TryParse(s, out int nInt))
                    {
                        didgitals.typeSecondDidgit = nInt.GetType();
                        didgitals.secondDidgit = (int)nInt;                       
                        break;
                    }
                    else if (double.TryParse(s, out double nDouble))
                    {
                        didgitals.typeSecondDidgit = nDouble.GetType();
                        didgitals.secondDidgit = (double)nDouble;                      
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not a didgit!");
                    }
                }

                // реализация
                Consider(didgitals);

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
