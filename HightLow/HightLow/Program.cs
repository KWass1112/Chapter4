using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HightLow
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int userEntry;
            int rndNumber = rnd.Next(1, 10);
            string choice;
            Console.WriteLine("Enter a number between 1 and 10");
            userEntry = Convert.ToInt32(Console.ReadLine());

            if (userEntry == rndNumber)
            {
                Console.WriteLine("How did you guess, it was {0}", userEntry);
                Console.WriteLine("Double or nothing?");
                choice = Console.ReadLine();
                if (choice.Equals("yes"))
                {
                    Console.WriteLine("You would risk what you have?");
                }
            }
            else
            {
                Console.WriteLine("{0} was wrong", userEntry);
            }
        }
    }
}
