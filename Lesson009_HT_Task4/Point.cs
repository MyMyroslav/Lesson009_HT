using System;

namespace Lesson009_HT_Task4
{
    public class Point
    {
        public string type;

        public string Type
        {
            get { return type; }
        }

        public int x;
        public int y;

        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }
        public Point()
        {

        }
        public Point(string type, int x, int y)
        {
            this.x = x;
            this.y = y;
            this.type = type;
        }
    }
}
