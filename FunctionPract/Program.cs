using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPract
{
    class Program
    {
        static void Main(string[] args)
        {

            //// userDef();
            //Console.WriteLine("Please enter a name");
            //string nam = Console.ReadLine();
            //greet(nam);
            //sayNiceD();

            //Console.WriteLine("Please enter first number");
            //int num1 = Convert.ToInt32( Console.ReadLine());

            //Console.WriteLine("Please enter second number");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //sumNum(num1, num2);

            //Console.WriteLine("The sum of the two numbers are: {0} ", sumNum(num1, num2));



        }
        //Write a program in C# Sharp to create a user define function
        //public static void  userDef()
        //{
        //    Console.WriteLine("Welcome Friends!");

        //    Console.WriteLine("Have a Nice day!");

        //}

        //Write a program in C# Sharp to create a user define function with parameters.
        //public static void greet(string nam)
        //{
        //    Console.WriteLine("Welcome Friend " + nam + "!");

        //}

        //public static void sayNiceD()
        //{

        //    Console.WriteLine("Have a nice Day!");
        //}

        //Write a program in C# Sharp to create a function for the sum of two numbers.

        //public static int sumNum(int num1, int num2)
        //{
        //    return num1 + num2;

        //}

            Console.WriteLine("Please some string");
            string userStr = Convert.ToString(Console.ReadLine());

        // Write a program in C# Sharp to create a function to input a string and count number of spaces are in the string

        public static int  numSpace(string userString)

        {
            int strCount = 0;
            string str;
            for (int i = 0; i < userString.Length; i++)
            {
                str = userString.Substring(i, 1);
                if (str == "")
                {
                    strCount++;

                }
                return strCount;

            }


           
        }



    }

}


