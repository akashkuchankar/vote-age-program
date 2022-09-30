using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vote_age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the age");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine(" valid for voting")
                    ;
            }
            else
            {
                Console.WriteLine("not valid for voting")
                    ;
            }
        }
    }
}
