using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestClass2;

namespace TestClassProgram
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter dimension:");
            double input = Convert.ToDouble(Console.ReadLine());

            Circle circle1 = new Circle();
            Square square1 = new Square();

            int i;
            for (i = 0; i < 10; i++)
            {
                //input += i;

                circle1.Radius = input + i;
                square1.Width = input + i;
                Console.WriteLine("Circle Radius = {0}", circle1.Radius);
                Console.WriteLine("Circle Area = {0}", Math.Round(circle1.Area,4));
                Console.WriteLine("Circle Perimeter = {0}", Math.Round(circle1.Perimeter,4));
                Console.WriteLine("Square Width = {0}", square1.Width);
                Console.WriteLine("Square Area = {0}", square1.Area);
                Console.WriteLine("Square Perimeter = {0}", square1.Perimeter);

            }
            Console.ReadLine();





        }
    }
}
