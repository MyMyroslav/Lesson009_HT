using System;

namespace Lesson009_HT_Task4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Figure figure = new Figure(new Point("A", 1, 8), new Point("B", 1, 12), new Point("C", 4, 9));
            Figure figure2 = new Figure(new Point("A", 1, 2), new Point("B", 1, 3), new Point("C", 3, 5), new Point("D", 3, 6));
            Figure figure3 = new Figure(new Point("A", 1, 2), new Point("B", 2, 3), new Point("C", 3, 5), new Point("D", 7, 6), new Point("E",5,6));

            Console.Write("{0}, P = ", figure.NameOfShape);
            figure.PerimeterCalculator();
            Console.WriteLine("\n--------------------------------");
            Console.Write("{0}, P = ", figure2.NameOfShape);
            figure2.PerimeterCalculator();
            Console.WriteLine("\n--------------------------------");
            Console.Write("{0}, P = ", figure3.NameOfShape);
            figure3.PerimeterCalculator();

            // Delay.
            Console.ReadKey();


        }
    }
}
