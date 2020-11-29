using System;

namespace Lesson009_HT_Task4
{
    public class Figure : Point
    {
        Point[] point;

        string nameOfShape;
        public string NameOfShape
        {
            get { return nameOfShape; }
        }

        double LengthOfSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((B.Y - A.Y), 2) + Math.Pow((B.X - A.X), 2));
        }
        public void PerimeterCalculator()
        {
            double sum = 0;

            for (int i = 0; i < point.Length - 1; i++)
            {
                sum += LengthOfSide(point[i], point[i + 1]);
            }

            sum += LengthOfSide(point[point.Length - 1], point[0]);
            Console.Write(sum);
        }
        public Figure(Point A, Point B, Point C)
        {
            point = new Point[3];
            point[0] = A;
            point[1] = B;
            point[2] = C;
            nameOfShape = "Triangle";
        }

        public Figure(Point A, Point B, Point C, Point D)
        {
            point = new Point[4];
            point[0] = A;
            point[1] = B;
            point[2] = C;
            point[3] = D;
            nameOfShape = "Quadrangle";
        }

        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            point = new Point[5];
            point[0] = A;
            point[1] = B;
            point[2] = C;
            point[3] = D;
            point[4] = E;
            nameOfShape = "Pentagon";
        }

    }
}
