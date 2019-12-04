using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int com = rnd.Next(1, 3);
            int entry;
            int wins = 0;
            bool again = true;

            Console.WriteLine("Welcome to rock, paper, scissors.");
            while (again)
            {
                Console.WriteLine("Enter one of the following numbers to play: " + "\n1 - Rock \n2 - Paper \n3 - Scissors");
                entry = Convert.ToInt32(Console.ReadLine());


                if (com == 1)
                {
                    if (entry == 1)
                    {
                        Console.WriteLine("Its a tie.");
                    }
                    else if (entry == 2)
                    {
                        Console.WriteLine("You win");
                        wins = wins + 1;
                    }
                    else
                    {
                        Console.WriteLine("You lost");
                        
                    }
                }
                else if (com == 2)
                {
                    if (entry == 2)
                    {
                        Console.WriteLine("Cats game.");
                    }
                    else if (entry == 1)
                    {
                        Console.WriteLine("Paper covers rock.");
                    }
                    else
                    {
                        Console.WriteLine("Scissors cut paper.");
                        wins = wins + 1;
                    }
                }
                if (com == 3)
                {
                    if (entry == 3)
                    {
                        Console.WriteLine("Draw");
                    }
                    else if (entry == 2)
                    {
                        Console.WriteLine("Loss.");
                    }
                    else
                    {
                        Console.WriteLine("Rock beats scissors.");
                        wins = wins + 1;
                    }
                }
                if (wins == 10)
                {
                    Console.WriteLine("You beat the game.");
                    again = false;
                }
                Console.WriteLine("You have won " + wins + " times.");
            }
        }
    }
}