using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int entry;
            Console.WriteLine("Pick one of these three doors");
            entry = Convert.ToInt32(Console.ReadLine());
            if (entry == 1)
            {
                Console.WriteLine("You failed");
            }
            else if(entry == 2)
            {
                Console.WriteLine("Failier");
            }
            else if(entry == 3)
            {
                Console.WriteLine("You did it, you lost");
            }
        }
    }
}
