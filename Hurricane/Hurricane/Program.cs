using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hurricane
{
    class Program
    {
        static void Main(string[] args)
        {
            int userWindSpeed;

            Console.WriteLine("Enter a hurricanes wind speed.");
            userWindSpeed = Convert.ToInt32(Console.ReadLine());

            if (userWindSpeed == 157)
            {
                Console.WriteLine("Thats a category 5!!!!");
            }
            else if (userWindSpeed == 130)
            {
                Console.WriteLine("Thats a category 4!!");
            }
            else if (userWindSpeed == 111)
            {
                Console.WriteLine("Thats a category 3!");
            }
            else if (userWindSpeed == 96)
            {
                Console.WriteLine("Thats a category 2.");
            }
            else if (userWindSpeed == 74)
            {
                Console.WriteLine("Thats a category 1.");
            }
            else if (userWindSpeed < 74)
            {
                Console.WriteLine("Thats not a hurricane.");
            }
        }
    }
}
