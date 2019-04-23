using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Enter an integer value between 1 and 100.");
            number = int.Parse(Console.ReadLine());

            if (number<1 || number>100)
            {
                Console.WriteLine("That isn't between 1 and 100!");
            }
            else if (number % 2 == 0) //even
            {
                Console.Write("Even ");
                // skipping 25-60 because it's redundant
                if(number <= 25) // lab says in the range of 2 to 25 and it can't be one or below
                {
                    Console.WriteLine("and less than 25.");
                }
                if(number > 60)
                {
                    Console.WriteLine(number);
                }
            }
            else //odd
            {
                Console.Write("Odd ");
                if (number > 60)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
