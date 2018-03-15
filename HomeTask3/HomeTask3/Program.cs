using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask3
{
    class Program 
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            
            Console.WriteLine("name:");
            st.Name = Console.ReadLine();
            Console.WriteLine("Sername:");
            st.Sername = Console.ReadLine();
            Console.WriteLine("PoBatjushki:");
            st.PoBatjushki = Console.ReadLine();
            Console.WriteLine("Grup:");
            st.Grup = Console.ReadLine();
            Console.WriteLine("Age:");
            st.Age = Console.ReadLine();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("what to do with the student?");
                Console.WriteLine(" - print data student : enter 'p'");
                Console.WriteLine(" - add raring : enter 'a'");
                Console.WriteLine(" - show average ball by subject  : enter 's'");
                Console.WriteLine(" - exit : enter 'e'");

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.KeyChar == 'p') // печеть
                {
                    st.PrintStudentData();
                }
                else if (keyInfo.KeyChar == 's') // среднее по предмету
                {
                    while (true)
                    {
                        Console.WriteLine();
                        Console.WriteLine("which subject rating show ?");
                        Console.WriteLine(" - Programming : enter 'p'");
                        Console.WriteLine(" - Administration : enter 'a'");
                        Console.WriteLine(" - Design : enter 'd'");
                        Console.WriteLine(" - exit : enter 'e'");

                        ConsoleKeyInfo keyI = Console.ReadKey();
                        
                        if (keyI.KeyChar == 'e')
                        {
                            break;
                        }
                        else if (keyI.KeyChar == 'p' || keyI.KeyChar == 'a' || keyI.KeyChar == 'd')
                        {
                            Console.WriteLine();
                            st.ShowAverageBall(keyI.KeyChar);                         
                        }
                        else
                        {
                            Console.WriteLine(" wrong key!");
                        }
                    }                  
                }
                else if (keyInfo.KeyChar == 'a') // добавление оценки к предмету
                {                           
                    while (true)
                    {
                        Console.WriteLine();
                        Console.WriteLine("on which subject to add ?");
                        Console.WriteLine(" - Programming : enter 'p'");
                        Console.WriteLine(" - Administration : enter 'a'");
                        Console.WriteLine(" - Design : enter 'd'");
                        Console.WriteLine(" - exit : enter 'e'");

                        ConsoleKeyInfo key = Console.ReadKey();                       
                        if (key.KeyChar == 'e')
                        {
                            break;
                        }
                        else if(key.KeyChar =='p' || key.KeyChar == 'a' || key.KeyChar == 'd')
                        {
                            Console.WriteLine();
                            Console.WriteLine("enter rating: ");
                            string rat = Console.ReadLine();
                            st.AddEstimate(key.KeyChar, rat);
                        }
                        else
                        {
                            Console.WriteLine(" wrong key!");
                        }                     
                    }
                }
                else if (keyInfo.KeyChar == 'e')
                {
                    break;
                }
                else
                {
                    Console.Write("\nnot a command!");
                }
            }
        }
    }
}
