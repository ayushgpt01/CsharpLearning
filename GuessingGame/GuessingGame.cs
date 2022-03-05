using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guess
{
    class Program
    {
        static void Main()
        {
            string ch = "Y";
            do
            {
                Random random = new Random();
                Console.Write("Enter max number to guess : ");
                int max = Convert.ToInt32(Console.ReadLine());
                int target = random.Next(max + 1);
                int guess, count = 0;
                while (true)
                {
                    Console.Write("Enter your guess between 0 and {0} : ", max);
                    guess = Convert.ToInt32(Console.ReadLine());
                    count++;
                    if (guess == -1)
                    {
                        Console.Write("Do you Really want to quit? Y/N : ");
                        string s = Console.ReadLine();
                        if (s == "Y" || s == "y")
                        {
                            Console.WriteLine("You quit the game in {0} counts ... ", count);
                            return;
                        }
                    }
                    if (guess >= 0 && guess <= max)
                    {
                        if (guess == target)
                        {
                            Console.WriteLine("Correct guess \nCongrats you win in {0} tries!!", count);
                            break;
                        }
                        else if (guess < target)
                        {
                            Console.WriteLine("Too Low. \nGuess higher to win");
                        }
                        else if (guess > target)
                        {
                            Console.WriteLine("Too High.\nGuess lower to win");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number between 0 and {0}", max);
                    }
                }
                Console.Write("Do you want to play the game again ? (Y/N) : ");
                ch = Console.ReadLine();
            } while (ch!="N"&&ch!="n");
            Console.WriteLine("Exiting .....");
        }
    }
}