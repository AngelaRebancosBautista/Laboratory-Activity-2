using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Activity_2
{
    internal class Program
    {
        static void Main(string[] args)

        {

            int ageInMonths;
            int age;
            Console.Write("Enter your age in years (1 to 120): ");
            age = int.Parse(Console.ReadLine());


            if (age >= 1 && age <= 120)
            {
                ageInMonths = age * 12;
                Console.WriteLine($"You are {ageInMonths} months old.");
            }
            else
            {
                Console.WriteLine("Invalid input. Age must be between 1 and 120.");
            }
        }
    }
}


