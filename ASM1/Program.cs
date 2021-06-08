using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            Ex3();
            Console.ReadKey();
        }

        public static void Ex1()
        {
            int studentID;
            String studentName;
            int studentAge;
            String studentGender;
            double percentage;

            System.Console.Write("\nEnter Student ID: ");
            studentID = int.Parse(Console.ReadLine());

            System.Console.Write("Enter Student Name: ");
            studentName = Console.ReadLine();

            System.Console.Write("Enter Student Age: ");
            studentAge = int.Parse(Console.ReadLine());

            System.Console.Write("Enter Student Gender: ");
            studentGender = Console.ReadLine();

            System.Console.Write("Percentage: ");
            percentage = double.Parse(Console.ReadLine());
        }
        /// <summary>
        /// <param name="args">This is exercise 2</param>
        /// <returns>void</returns>
        /// </summary>
        /// <remarks>
        /// This is comment...
        /// </remarks>
        public static void Ex2()
        {
            System.Console.WriteLine("\nPlease see source code for comment");
        }

        public static void Ex3()
        {
            const int literal = 100;
            String studentName;
            double math, eng, phys;
            double percent = 0;

            System.Console.Write("\nEnter name: ");
            studentName = Console.ReadLine();
            System.Console.Write("\nMaths mark: ");
            math = Convert.ToDouble(Console.ReadLine());
            System.Console.Write("English mark: ");
            eng = Convert.ToDouble(Console.ReadLine());
            System.Console.Write("Physics mark: ");
            phys = Convert.ToDouble(Console.ReadLine());

            percent = (math * eng * phys) * literal / 300;

            System.Console.WriteLine("Student information:");
            System.Console.WriteLine($"Name: {studentName}");
            System.Console.WriteLine($"Maths mark: {math}");
            System.Console.WriteLine($"English mark: {eng}");
            System.Console.WriteLine($"Physics mark: {phys}");
            System.Console.WriteLine($"Percentage: {percent}");
        }
    }
}
