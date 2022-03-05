using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int names;
            float total = 0;
            float per = 0;
            int marks = 5;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            //int[] marks = new int[] { };

            Console.Write("How many students' marks you want to print??  : ");
            names = int.Parse(Console.ReadLine());
            string[] stds = new string[names];
            int[,] school = new int[names, marks];
            //input
            for (int i = 0; i < names; i++)
            {
                Console.Write("Enter the names of the student No.{0}  :", (i + 1));
                stds[i] = Console.ReadLine();
                Console.Write("Enter the 5 subject's marks of student No.{0} (out of 100) :\n", (i + 1));
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine("subject No. {0} :" , (j + 1));
                    school[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }
            //Console.ResetColor();
            //display

            for (int i = 0; i < names; i++)
            {
                Console.WriteLine("");
                Console.Write("name of student :" + stds[i] + "  ");

                for (int j = 0; j < 5; j++)
                {

                    total += school[i, j];
                   

                }
             
                per = (total / 500) * 100;
                //Console.ResetColor();
                if (per < 35)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(total + "    ");
                    Console.Write("percentage : " + per + "   ");
                    //Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else if(per>36 && per<70)
                   {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(total + "    ");
                    Console.Write("percentage : " + per + "   ");
                    //Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else if (per > 69)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(total + "    ");
                    Console.Write("percentage : " + per + "   ");
                    //Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                }

                total = 0;
                per = 0;

            }



            Console.ResetColor();

           

            Console.ReadLine();

        }


    }
}