using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Passing Objects to functions by Reference.
namespace Assignment_3
{
    class StudentSwap
    {
        public int id;
        public string name;
        public int mark;
        public void read()
        {
            Console.WriteLine("Enter the id");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the mark");
            mark = int.Parse(Console.ReadLine());
        }
        public void swap(StudentSwap val, StudentSwap val2)
        {
            StudentSwap temp = new StudentSwap();
            temp = val;
            val = val2;
            val2 = temp;
            Console.WriteLine("After Swapping");
            val.display();
            val2.display();
        }
        public void display()
        {
            Console.WriteLine("Id: {0}", id);
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Mark: {0}", mark);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StudentSwap std1 = new StudentSwap();
            StudentSwap std2 = new StudentSwap();
            std1.read();
            std2.read();
            Console.WriteLine("Before Swapping");
            std1.display();
            std2.display();
            std1.swap(std1, std2);

            Console.ReadLine();
        }

    }
}
