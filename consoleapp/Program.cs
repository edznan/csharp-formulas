using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formulas
{ 

    class Program
    {
        public static void Main()
        {
            //circle area and circumference
            double c1; //radius
            double c2; //area
            double c3; //circumference
            double PI = 3.14;

            Console.WriteLine("Enter radius of circle : ");
            c1 = Convert.ToDouble(Console.ReadLine()); //get user input

            //A = π*r*r
            c2 = PI * c1 * c1; 
            Console.WriteLine("\nArea of circle is {0}", c2);

            //C = 2*r*π
            c3 = 2 * c1 * PI;
            Console.WriteLine("\nCircumference of circle is {0}", c3);



            //triangle area and circumference
            double t1; //base
            double t2; //height
            double t3; //area
            double t4; //sideA
            double t5; //sideB
            double t6; //circumference
           
            Console.WriteLine("Enter base of triangle : ");
            t1 = Convert.ToDouble(Console.ReadLine()); //get user input

            Console.WriteLine("\nEnter height of triangle  : ");
            t2 = Convert.ToDouble(Console.ReadLine()); //get user input

            Console.WriteLine("\nEnter side 1 of triangle  : ");
            t4 = Convert.ToDouble(Console.ReadLine()); //get user input

            Console.WriteLine("\nEnter side 2 of triangle  : ");
            t5 = Convert.ToDouble(Console.ReadLine()); //get user input

            //C = a + b + c
            t6 = t1 + t4 + t5;

            //A = (1/2) * base * height
            t3 = 0.5 * t1 * t2;

            Console.WriteLine("\nArea of triangle is {0}", t3);
            Console.WriteLine("\nCircumference of triangle is {0}", t6);



            //square area and circumference
            int s1; //side
            int s2; //area
            int s3; //circumference

            Console.Write("Please enter the value of the sides of square : ");
            s1 = Convert.ToInt32(Console.ReadLine()); //get user input
            
            //A = a*a
            s2 = s1 * s1;

            //C = 4 * a
            s3 = s1 * 4;

            Console.WriteLine("\nArea of square : " + s2);
            Console.WriteLine("\nCircumference of square : " + s3);
            


            //rectangle area and circumference
            double r1; //side 1
            double r2; // side 2
            double r3; // area
            double r4; // circumference

            Console.Write("Enter rectangle height : ");
            r1 = Convert.ToInt32(Console.ReadLine()); //get user input

            Console.Write("\nEnter rectangle width : ");
            r2 = Convert.ToInt32(Console.ReadLine()); //get user input

            //A = a * b
            r3 = r1 * r2;

            //C = 2a + 2b
            r4 = 2 * (r1 + r2);

            Console.Write("\nArea of rectangle is {0}", r3);
            Console.WriteLine("\nCircumference of rectangle is {0}", r4);



            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();  //output


        }
    }
}
