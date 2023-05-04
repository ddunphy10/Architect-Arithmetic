using System;

namespace ArchitectArithmetic
{
    class Program
    {
        public static void Main(string[] args)
        {
            TitleIntro();
            Examples();            
        }
        static void TitleIntro()
        {
            Console.WriteLine("ARCHITECT ARITHMETIC\n");
            Console.WriteLine();
            Console.WriteLine("Some examples of area calculations are below:\n");
            Console.WriteLine("Area of 4 x 5 rectangle: " + RectangleArea(4, 5));
            Console.WriteLine("Area of circle with radius 4: " + CircleArea(4));
            Console.WriteLine("Area of triangle with base 10 and height of 9: " + TriangleArea(10, 9));
            Console.WriteLine();
        }
        static void Examples()
        {
            double totalArea = RectangleArea(1500, 2500) + TriangleArea(750, 500) + ((CircleArea(375)) / 2);
            double roundedTotalArea = Math.Round(totalArea, 2);
            double totalCost = totalArea * 180;
            double roundedTotalCost = Math.Round(totalCost, 2);

            Console.WriteLine($"Calculating the area of a building that consists of roughly one rectangle that is 1500 by 2500, one triangle with a base of 750 and a height of 500, and one half circle with a radius of 375 comes to {totalArea} " +
                $"before rounding. If we were to round that number to two decimal places it would be {roundedTotalArea}\n");


            Console.WriteLine($"To calculate the total cost of flooring for tile costing 180 Mexican Pesos per square unit we would need to calculate the total are of the building. The total area of the building is approximately {totalArea} " +
                $"multiplying that times 180 Mexican pesos comes out to approximately {roundedTotalCost} Mexican pesos for a total cost.");
        }
        static double RectangleArea(double length, double width)
        {
            double area = length * width;
            return area;
        }
        static double CircleArea(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
        static double TriangleArea(double bottom, double height)
        {
            double area = .5 * bottom * height;
            return area;
        }
    }
}
