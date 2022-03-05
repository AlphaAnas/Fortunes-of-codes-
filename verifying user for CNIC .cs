using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_c_sharp_anas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to NADRA Data Base :");
          a:  Console.WriteLine("What service do you want\n Press 1. for making new CNIC");
            int input=int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    { Console.WriteLine("Enter your age :");
                        break;
                    }
            }
            int age = int.Parse(Console.ReadLine());
            if (age > 17)
            {
                Console.WriteLine("You are eligible to apply....\n please wait.....");
            }
            else { Console.WriteLine("You are not eligible to apply due to age factor !!! ");
                goto a;
            }
            Console.ReadKey();
        }
    }
}
