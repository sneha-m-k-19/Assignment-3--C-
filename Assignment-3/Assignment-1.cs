using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create a class student with attribute name and roll number and a method displaydetails() for displaying the same.Create two instance of the class and call the method for each instance
namespace Assignment_3
{
    public class Student
    {
        public string name;
        public int rollNumber;

        public void DisplayDetails()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Roll Number: " + rollNumber);
        }
    }
    public class Assignment
    {   
        public static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.name = "Sneha";
            s1.rollNumber = 5;

            Student s2 = new Student();
            s2.name = "Theja";
            s2.rollNumber = 7;

            s1.DisplayDetails();
            s2.DisplayDetails();
            Console.ReadLine();
        }
        
    }

}
