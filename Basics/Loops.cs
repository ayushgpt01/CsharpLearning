using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            // while loop
            Console.WriteLine("While Loop :- ");
            while(i < 10)
            {
                Console.WriteLine("Index : " + ++i);
            }
            i = 0;
            // do-while
            Console.WriteLine("Do - While Loop :- ");

            do
            {
                Console.WriteLine("Index : "+ ++i);
            } while(i < 10);

            //for loop
            Console.WriteLine("For Loop :- ");

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Index : "+ i);
            }
        }
    }
}