using System;
namespace Lesson009_HT_Task2
{
    public class Rectangle
    {
        private double side1;
        private double side2;
        private double area;
        private double perimeter;
        public double Perimeter { get; set; }
        public Rectangle()
        {
        }
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public double AreaCalculator(double side1, double side2)
        {
            area = side1 * side2;
            return area;
        }
        public double PerimeterCalculator(double side1, double side2)
        {
            perimeter = 2 * (side1 + side2);
            return perimeter;
        }

        public double dblArea
        {
            get
            {
                if (area != 0)
                {
                    return area;
                }
                else
                {
                    Console.WriteLine("Area is empty");
                    return 0;
                }
            }
        }
        public double dblPerimeter
        {
            get
            {
                if (perimeter != 0)
                {
                    return perimeter;
                }
                else
                {
                    Console.WriteLine("Perimeter is empty");
                    return 0;
                }
            }
        }
    }
}
