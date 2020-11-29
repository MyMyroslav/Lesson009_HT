using System;

namespace Lesson009_HT_Task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Rectangle el = new Rectangle(2,4);
            Console.WriteLine($"{el.dblArea}, {el.dblPerimeter}");
            double motion1 = el.AreaCalculator(2,4);
            double motion2 = el.PerimeterCalculator(2, 4);
            Console.WriteLine($"{el.dblArea}, {el.dblPerimeter}");            

        }
    }
}
