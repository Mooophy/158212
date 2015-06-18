using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection.Emit;


namespace JuestForCshap
{
    class Program
    {

        static string BmiSpan(float bmi)
        {
            if (bmi < 0)
                return "BMI CALCULATION ERROR";
            else if (bmi < 18.5)
                return "UNDERWEIGHT";
            else if (bmi >= 25 && bmi < 30)
                return "OVERWEIGHT";
            else
                return "OBESE";
        }

        static float BmiGetInput(string msg)
        {
            float result = 0;
            while (true)
            {
                Console.WriteLine(msg);
                int i = 0;
                if (int.TryParse(Console.ReadLine(), out i))
                {
                    result = i;
                    break;
                }
                Console.WriteLine("Invalid input, please enter again\n");
            }
            return result;
        }

        static string BmiCalculate()
        {
            float height = Program.BmiGetInput("Enter a positive value for height in meters");
            Console.WriteLine("The .....for height was: " + height);
            float weight = Program.BmiGetInput("Enter a positive value for weight in meters");
            Console.WriteLine("The .....for height was: " + weight);
            
            float bmi = weight / (float)(Math.Pow((double)height, 2.0));
            return Program.BmiSpan(bmi);
        }

        static void Main(string[] args)
        {

        }
    }
}
