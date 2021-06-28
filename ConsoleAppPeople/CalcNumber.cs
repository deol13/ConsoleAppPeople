using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppPeople
{
    class CalcNumber
    {
        //params does so we can use any numbers of doubles as arguments to this function
        public static double Addition(params double[] numbers)
        {
            double sum = 0;

            foreach (double num in numbers)
            {
                sum += num;
            }

            return sum;
        }

        public static void Example()
        {
            //This works because of params
            double[] numbers = new double[] { 1, 2, 3 };
            double result = CalcNumber.Addition(numbers);
            Console.WriteLine("Sum: " + result);

            result = CalcNumber.Addition(6.0, 60.0, 600.0);
            Console.WriteLine("Sum: " + result);

            result = CalcNumber.Addition(6.0, 60.0);
            Console.WriteLine("Sum: " + result);
        }
    }
}
