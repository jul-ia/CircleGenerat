using System;

namespace dz_circle
{
    class Point
    {
        float x, y;

        public Point()
        {
            x = y = 0;
        }
        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public float X
        {
            set { x = value; }
            get { return x; }
        }
        public float Y
        {
            set { y = value; }
            get { return y; }
        }

        public float calcLength(Point otherPoint)
        {
            return (float)Math.Sqrt(Math.Pow((x - otherPoint.X), 2) + Math.Pow(y - otherPoint.Y, 2));
        }
    }
}
