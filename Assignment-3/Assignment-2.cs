using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//: Implement Run Time Polymorphism.
namespace Assignment_3
{
    public class ClassA  //baseclass
    {
        public virtual void View()
        {
            Console.WriteLine("Welcome ! ClassA");
        }
    }
    public class ClassB : ClassA //derived class
    {
        public override void View()
        {
            Console.WriteLine("Welcome Class B");
        }
    }
    public class Assignment_2
    {
        static void Main(string[] args)
        {
            ClassB B = new ClassB();
            B.View();
            ClassA A = new ClassA();
            A.View();
            Console.ReadLine();
        }
    }
}
