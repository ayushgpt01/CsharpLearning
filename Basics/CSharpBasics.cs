using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    class Program
    {
        static void DataTypes()
        {
            Console.WriteLine("\nData Types : \n");
            string str = "I am a String";  //any string
            Console.WriteLine("string : " + str);
            char grade = 'A'; // a single character
            Console.WriteLine("char : " + grade);
            int num = 0; // numbers || range (-2^31 to 2^31 - 1)
            Console.WriteLine("int : " + num);
            long largeNum = 19992999199219; // anything greater than int
            Console.WriteLine("long : " + largeNum);
            float price = 19.99f; // 6-9 decimals
            Console.WriteLine("float : " + price);
            double newPrice = 19.99; // 15-17 decimals
            Console.WriteLine("double : " + newPrice);
            decimal newestPrice = 19.99m; // 28-29 decimals
            Console.WriteLine("decimal : " + newestPrice);
            bool isTrue = true; // true or false
            Console.WriteLine("bool : " + isTrue);
            bool isFalse = false;
            Console.WriteLine("bool : " + isFalse);
        }

        static void Strings()
        {
            string str = "Just a String";
            string str2 = "Another String";
            // Print a string
            Console.WriteLine(str);
            // Concat strings
            Console.WriteLine(str + " " + str2);
            // length of a string
            Console.WriteLine("Length of \"" + str + "\" is " + str.Length);
            // String Methods
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str2.ToLower());
            Console.WriteLine(str2.Contains("String")); // Case-sensitive
            Console.WriteLine(str2.IndexOf("Str")); // Also tells the index of first appearance (-1 if not present)
            Console.WriteLine(str2.Substring(8,3)); // grabs a substring (startIndex , No. of characters to grab = default until end of string)
            // First Character
            Console.WriteLine(str[0]);
        }

        static void numbers()
        {
            // Variable initialisation
            int a = 10;
            int b = 20;
            double c = 1.99;
            // Operations
            Console.WriteLine("Add :" + (a + b)); // need brackets otherwise it will concat with string
            Console.WriteLine("Subtract :" + (a - b));
            Console.WriteLine("Multiply :" + a * b);
            Console.WriteLine("Divide :" + b / a); // if both are integers then this returns integer 
            Console.WriteLine("Modulus (Remainder) :" + b % a);
            // shorthands
            a++;
            b--;
            // Math methods
            Console.WriteLine("Abs :" + Math.Abs(-2.88)); // absolute value (gives only the magnitude)
            Console.WriteLine("Pow :" + Math.Pow(2,3)); // power
            Console.WriteLine("Sqrt :" + Math.Sqrt(b));
            Console.WriteLine("Max :" + Math.Max(1,2));
            Console.WriteLine("Min :" + Math.Min(1, 2));
            Console.WriteLine("Round :" + Math.Round(1.5)); // 0.1-0.4 -> n-1 || 0.5-0.9 -> n
        }

        static void Main(string[] args)
        {
            // Entering Input and Displaying Output
            Console.Write("Enter your name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name);

            // Methods : 
            //DataTypes();
            //Strings();
            //numbers();

        }
    }
}