using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            // Flow Control using switch
            Console.Write("Enter a day number : ");
            Console.WriteLine(getDay(Convert.ToInt32(Console.ReadLine())));
        }

        static string getDay(int dayNum)
        {
            string dayName;

            switch(dayNum)
            {
                case 0: 
                    dayName = "Sunday";
                    break;
                case 1: 
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default: 
                    dayName = "Wrong Day";
                    break;
            }

            return dayName;
        }
    }
}