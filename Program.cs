using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double Angle = 0.0; char Option = '0';
            while (Option != '4')
            {
                Menu(ref Option);
                switch (Option)
                {
                    case '1':
                        {
                            Radianconverter(ref Angle);
                            break;
                        }
                    case '2':
                        {
                            Square();
                            break;
                        }
                    case '3':
                        {
                            Triangle();
                            break;
                        }
                    case '4':
                        {
                            Circle();
                            break;
                        }
                }
            }
        }
        static void Menu(ref char Op)
        {
            Console.WriteLine("          |||Principal menu|||   \n\n");
            Console.WriteLine("1. Convert from degrees to radians.");
            Console.WriteLine("2. Calculate the area of a square.");
            Console.WriteLine("3. Calculate the area of a triangle.");
            Console.WriteLine("4. Calculate the area of a circle.");
            Console.WriteLine("3. End program.\n");
            Console.Write("What do you want to do: ");
            Op = Convert.ToChar(Console.ReadLine());
            Console.Clear();
        }
        static void Radianconverter(ref double Angle)
        {
            double RAngle;
            Console.WriteLine("       |||Menu Angle converter|||   \n\n");
            Console.Write("Write the angle in degrees: ");
            Angle = Convert.ToDouble(Console.ReadLine());
            RAngle = (Angle * Math.PI) / 180;
            Console.WriteLine("{0} degrees in radians is: {1}",Angle ,RAngle);
            Console.ReadKey();
            Console.Clear();
        }
        static void Square()
        {
            double Side, Area;
            Console.WriteLine("       |||Menu area of Square|||   \n\n");
            Console.Write("Write the lenght of one side: ");
            Side = Convert.ToDouble(Console.ReadLine());
            Area = Math.Pow(Side, 2);
            Console.WriteLine("The area of the square with a side of {0} is: {1}",Side, Area);
            Console.ReadKey();
            Console.Clear();
        }
        static void Triangle()
        {
            double Base, Height, Area;
            Console.WriteLine("       |||Menu area of Triangle|||   \n\n");
            Console.Write("Write the base lengt: ");
            Base = Convert.ToDouble(Console.ReadLine());
            Console.Write("Write the Height lengt: ");
            Height = Convert.ToDouble(Console.ReadLine());
            Area = (Base * Height) / 2;
            Console.WriteLine("Base: {0}\nHeight: {1}", Base, Height);
            Console.WriteLine("The area of the triangle is: {0}", Area);
            Console.ReadKey();
            Console.Clear();
        }
        static void Circle()
        {
            double Radius, Area;
            Console.WriteLine("       |||Menu area of circle|||   \n\n");
            Console.Write("Write the radius of the circle: ");
            Radius = Convert.ToDouble(Console.ReadLine());
            Area = Math.PI * Math.Pow(Radius, 2);
            Console.WriteLine("The area of the circle with a radius of {0} is: {1}",Radius , Area);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
