using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Program to create a function to input a string and count the number of spaces in the string.
namespace Assignment_3
{
    class Assignment_3
    {
        public static void Main(string[] args)
        {
            string str = "Welcome to Nest Digital family";
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                    count++;
            }

            Console.WriteLine("String :" + str);
            Console.Write("Number of spaces = " + count);
            Console.ReadLine();
        }
    }
}
