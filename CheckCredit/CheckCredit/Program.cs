using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckCredit
{
    class Program
    {
        static void Main(string[] args)
        {
            double entry;

            Console.WriteLine("Enter a price for an item >> ");
            entry = Convert.ToDouble(Console.ReadLine());

            if (entry > 5000) {
                Console.WriteLine("Disapproved");
            }
            else if (entry < 5000) {
                Console.WriteLine("Approved");
            }
        }
    }
}
