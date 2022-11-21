using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Passing Objects to functions by Reference.
namespace Assignment_3
{
    class SwapStudent
    {
        public int id;
        public string name;
        public int mark;
        public void read()
        {
            Console.WriteLine("Enter the Student id :");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Student Name :");
            name = Console.ReadLine();
            Console.WriteLine("Enter the mark :");
            mark = int.Parse(Console.ReadLine());
        }
        public void swap(SwapStudent S1, SwapStudent S2)
        {
            SwapStudent temp = new SwapStudent();
            temp = S1;
            S1 = S2;
            S2 = temp;
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
            SwapStudent s1 = new SwapStudent();
            SwapStudent s2 = new SwapStudent();
            s1.read();
            s2.read();
            Console.WriteLine("Before Swapping details :");
            s1.display();
            s2.display();
            s1.swap(s1, s2);
            Console.WriteLine("After Swapping Details :");
            s1.display();
            s2.display();
            Console.ReadLine();
        }
    }
 
}
