using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number : ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number : ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the operator (+,-,*,/,%): ");
            string oper = Console.ReadLine();

            if(oper == "+")
            {
                Console.WriteLine("Addition : " + (num1 + num2));
            } else if(oper == "-")
            {
                Console.WriteLine("Subtraction : " + (num1 - num2));
            } else if(oper == "*")
            {
                Console.WriteLine("Multiplication : " + (num1 * num2));
            }
            else if (oper == "/")
            {
                Console.WriteLine("Division : " + (num1 / num2));
            }
            else if (oper == "%")
            {
                Console.WriteLine("     Remainder left : " + (num1 % num2));
            } else
            {
                Console.WriteLine("Incorrect input - Invalid Operator");
            }
        }
    }
}