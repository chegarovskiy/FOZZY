using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask3
{
    public class Student 
    {
        private int t;
        public string Name;
        public string Sername;
        public string PoBatjushki;
        public string Grup;
        private string age;
        public string Age
        {
            get
            {             
                return age;
            }
            set
            {
                if (int.TryParse(value, out t))
                {
                    age = t.ToString();
                }
                else
                {
                    age = "not installed";
                }             
            }
        }

        List<int> EstimateProgramming = new List<int>();
        List<int> EstimateAdministration = new List<int>();
        List<int> EstimateDesign = new List<int>();

        public Student()
        {
        }

        public void PrintStudentData()
        {
            Console.WriteLine();
            Console.WriteLine($"Nane : {this.Name} PoBatjushki: {this.PoBatjushki} Sername: {this.Sername} " +
                              $"Grup: {this.Grup} Age: {this.Age}");        
        }

        public void ShowAverageBall(char subject)
        {
            switch (subject)
            {
                case 'p':
                    Console.WriteLine(EstimateProgramming.Sum() / EstimateProgramming.Count);
                    break;
                case 'a':
                    Console.WriteLine(EstimateAdministration.Sum() / EstimateAdministration.Count);
                    break;
                case 'd':
                    Console.WriteLine(EstimateDesign.Sum() / EstimateDesign.Count);
                    break;
            }
        }

        public void AddEstimate (char subject, string estimate )
        {
            int t;
            if (int.TryParse(estimate, out t))
            {
                if (int.Parse(estimate) > 0 && int.Parse(estimate) < 100)
                {
                    switch (subject)
                    {
                        case 'p':
                            EstimateProgramming.Add(int.Parse(estimate));
                            break;
                        case 'a':
                            EstimateAdministration.Add(int.Parse(estimate));
                            break;
                        case 'd':
                            EstimateDesign.Add(int.Parse(estimate));
                            break;
                    }                 
                }
                else
                {
                    Console.WriteLine("estimate must be more 0 and less 100");
                }
            }
            else
            {
                Console.WriteLine("incorrect estimate, enter didgitals");
            }
            
        }

    }
}
