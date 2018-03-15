using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertNumberInWord
{
    public class Converter
    {
        public List<string> hundreds100_900 = new List<string>{"","сто","двісті", "триста", "чотириса", "пятсот", "шістсот", "сімсот", "вісімсот", "девятсот"};
        public List<string> dozens10_19 = new List<string>{"десять", "одинадцять", "дванадцять", "тринадцять", "чотирнадцять", "пятнадцять", "шістнадцять", "сімнадцять", "вісімнадцять", "девятнадцять" };
        public List<string> dozens20_90 = new List<string> {"","","двадцять", "тридцять", "сорок", "пятдесят", "шістдесят", "сімдесят", "вісімдесят", "девяносто" };
        public List<string> units1_9 = new List<string>{"","один", "два", "три", "чотири", "пять", "шість", "сім", "вісім", "девять"};
        public int length { get; set; }
        public string str { get; set; }
        
        public static void Conv(Converter number)
        {
            int hundr = (int)Char.GetNumericValue(number.str[0]);     
            int doz = (int)Char.GetNumericValue(number.str[1]);
            int unit = (int)Char.GetNumericValue(number.str[2]);

            if (doz == 0 & unit == 0)
            {
                Console.WriteLine("{0}", number.hundreds100_900[hundr]);
            }    
            else if (doz == 1)
            {
                Console.WriteLine("{0} {1}", number.hundreds100_900[hundr], number.dozens10_19[unit]);
            }
            else if (doz == 0)
            {
                Console.WriteLine("{0} {1}", number.hundreds100_900[hundr],  number.units1_9[unit]);
            }
            else 
            {
                Console.WriteLine("{0} {1} {2}", number.hundreds100_900[hundr],  number.dozens20_90[doz], number.units1_9[unit]);
            }
        }
    }
}
