using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            double gpa;
            int testScore;

            Console.WriteLine("Enter a grade point average");
            gpa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a test score");
            testScore = Convert.ToInt32(Console.ReadLine());

            if (gpa >= 3 && testScore >= 60)
            {
                Console.WriteLine("Accepted");
            }
            else if (gpa < 3 && testScore >= 80)
            {
                Console.WriteLine("Accepted");
            }
            else
            {
                Console.WriteLine("Rejected");
            }
        }
    }
}
