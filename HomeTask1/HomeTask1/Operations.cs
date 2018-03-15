using System;

namespace HomeTask1
{
    public class Didgitals 
    {
        public double firstDidgit { get; set; }
        public double secondDidgit { get; set; }
        public Type typeFirstDidgit { get; set; }
        public Type typeSecondDidgit { get; set; }

        public static void Consider(Didgitals a )
        {          
            if (a.typeFirstDidgit == typeof(int) & a.typeSecondDidgit == typeof(int))
            {
                Console.WriteLine("{0} + {1} = {2}", a.firstDidgit, a.secondDidgit, (int)Addition(a));
                Console.WriteLine("{0} - {1} = {2}", a.firstDidgit, a.secondDidgit, (int)Difference(a));
                Console.WriteLine("{0} * {1} = {2}", a.firstDidgit, a.secondDidgit, (int)Multiplication(a));
                Division(a, out string ex, out double rez );
                if (ex !="")
                {
                    Console.WriteLine("{0} / {1} : {2}", a.firstDidgit, a.secondDidgit, ex);
                }
                else
                {
                    Console.WriteLine(String.Format("{0} / {1} = {2:0.####}", a.firstDidgit, a.secondDidgit, (int)rez));
                }                
            }
            if (a.typeFirstDidgit == typeof(double) | a.typeSecondDidgit == typeof(double))
            {
                Console.WriteLine(String.Format("{0} + {1} = {2:.####}", a.firstDidgit, a.secondDidgit, (double)Addition(a)));
                Console.WriteLine(String.Format("{0} - {1} = {2:0.####}", a.firstDidgit, a.secondDidgit, (double)Difference(a)));
                Console.WriteLine(String.Format("{0} * {1} = {2:.####}", a.firstDidgit, a.secondDidgit, (double)Multiplication(a)));
                Division(a, out string ex, out double rez);
                if (ex != "")
                {
                    Console.WriteLine("{0} / {1} : {2}", a.firstDidgit, a.secondDidgit, ex);
                }
                else
                {
                    Console.WriteLine(String.Format("{0} / {1} = {2:0.####}", a.firstDidgit, a.secondDidgit, (double)rez));
                }
            }                        
        }

        public static double Addition(Didgitals a)
        {
            return a.firstDidgit + a.secondDidgit;
        }

        public static double Difference(Didgitals a)
        {
            return a.firstDidgit - a.secondDidgit;
        }

        public static double Multiplication(Didgitals a)
        {
            return a.firstDidgit * a.secondDidgit;
        }

        public static double Division(Didgitals a, out string ex, out double rez)
        {
            ex = "";
            rez = 0;
            if (a.secondDidgit == 0)
            {
                ex = "division by zero is forbidden!";
                rez = 0;
            }
            else
            {
                rez = a.firstDidgit / a.secondDidgit;
            }
            return rez;
        } 
    }
}
