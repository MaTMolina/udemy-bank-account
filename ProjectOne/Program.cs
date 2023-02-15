using System;
using System.Globalization;

namespace FirstProject {
    internal class Program {
        static void Main(string[] args) {
            Triangle x, y;
            x = new Triangle();
            y = new Triangle();

            Console.WriteLine("Input X triangle sides: ");
            x.A = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.WriteLine("Input Y triangle sides: ");
            y.A = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);


            double areaX = x.getArea();
            double areaY = y.getArea();

            Console.WriteLine("X triangle Area: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Y triangle Area: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if(areaX > areaY) {
                Console.WriteLine("X triangle is greater than Y");
            } else {
                Console.WriteLine("Y triangle is greater than X");
            }
        }
    }
}
