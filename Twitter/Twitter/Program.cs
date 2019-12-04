using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter
{
    class Program
    {
        static void Main(string[] args)
        {
            string entry;

            Console.WriteLine("Type a message: ");
            entry = Console.ReadLine();

            if (entry.Length > 140)
            {
                Console.WriteLine("Didn't send message.");
            }
            else
            {
                Console.WriteLine("Message sent: " + entry);
            }
        }
    }
}
