using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Multilevel Inheritance
namespace Assignment_3
{
    public class StudentMI
    {
        private int Student_Id;
        private String Student_Name;
        public void Student_Read()
        {
            Console.WriteLine("Enter Student Id :");
            Student_Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student Name :");
            Student_Name = Console.ReadLine();
        }
        public void Student_display()
        {
            Console.WriteLine("Student_Id :{0}", Student_Id);
            Console.WriteLine("Student_Name :{0}", Student_Name);
        }
    }
    public class internals : StudentMI
    {
        protected int marks_internal;
        public void internals_Read()
        {
            base.Student_Read();
            Console.WriteLine("Enter Marks_internal :");
            marks_internal = int.Parse(Console.ReadLine());
        }
        public void internals_display()
        {
            base.Student_display();
            Console.WriteLine("Marks_internal :{0}", marks_internal);
        }
    }
    public class externals : internals
    {
        private int Marks_external;
        private int Marks_Total;
        public void externals_Read()
        {
            internals_Read();
            Console.WriteLine("Enter Marks_external");
            Marks_external = int.Parse(Console.ReadLine());
        }
        public void externals_Display()
        {
            internals_display();
            Console.WriteLine("Marks_external :{0}", Marks_external);
        }
        public int externals_Calculate()
        {
            Marks_Total = marks_internal + Marks_external;
            return Marks_Total;
        }
    }

    public class MainClass
    {
        public static void Main(string[] args)
        {
            externals e = new externals();
            e.externals_Read();
            e.externals_Display();
            Console.WriteLine("Total Marks :{0}", e.externals_Calculate());
            Console.ReadKey();
        }

    }
}
