using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isFact = true , isTrue = true;
            // flow control using if-else
            if (isFact && isTrue)
            {
                Console.WriteLine("Fact is true");
            } else if (isFact || isTrue)
            {
                // Nested if's
                if(isFact)
                {
                    Console.WriteLine("Fact isn't true");
                } else
                {
                    Console.WriteLine("It's true but isn't a fact");
                }
            } else
            {
                Console.WriteLine("False Information");
            }
        }
    }
}