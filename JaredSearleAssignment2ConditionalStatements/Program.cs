using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaredSearleAssignment2ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your expected grade for ISM 4300 as an integer.");
            Console.ReadKey(true);
            string input = Console.ReadLine();
            //Records input from user
            decimal grade = decimal.Parse(input);
            //Converts the input into a decimal format for conditional statement use.

            //Establishes parameters for grade calculation.
            if (grade >= 98)
            {
                Console.WriteLine("Your grade in this course is an A+.");
            }
            else if (grade >= 92)
            {
                Console.WriteLine("Your grade in this course is an A.");
            }
            else if (grade >= 90)
            {
                Console.WriteLine("Your grade in this course is an A-.");
            }
            else if (grade >= 88)
            {
                Console.WriteLine("Your grade in this course is an B+.");
            }
            else if (grade >= 82)
            {
                Console.WriteLine("Your grade in this course is an B.");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("Your grade in this course is an B-.");
            }
            else if (grade >= 78)
            {
                Console.WriteLine("Your grade in this course is an C+.");
            }
            else if (grade >= 72)
            {
                Console.WriteLine("Your grade in this course is an C.");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("Your grade in this course is an C-.");
            
            }
            else if (grade >= 68)
            {
                Console.WriteLine("Your grade in this course is an D+.");
            }
            else if (grade >= 62)
            {
                Console.WriteLine("Your grade in this course is an D.");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("Your grade in this course is an D-.");
            }
            else if (grade < 60)
            {
                Console.WriteLine("Your grade in this course is an F.");
            }

            Console.ReadKey(true);
            return; 

        }
    }
}
