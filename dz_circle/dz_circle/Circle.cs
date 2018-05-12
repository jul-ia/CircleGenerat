using System;

namespace dz_circle
{
    class Circle
    {
        Point center;
        float radius;

        public Circle()
        {
            center = new Point();
            radius = 1;
        }
        public Circle(float radius) : this()
        {
            this.radius = radius;
        }
        public Circle(float radius, Point c) : this(radius)
        {
            center = c;
        }
        public Circle(float radius, float x, float y)
        {
            this.radius = radius;
            center = new Point(x, y);
        }

        public float Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public Point Center
        {
            set { center = value; }
            get { return center; }
        }

        public bool collisionCheck(Circle otherCircle)
        {
            return ((radius + otherCircle.Radius) >= center.calcLength(otherCircle.Center));
        }

        public void print()
        {
            Console.WriteLine("Circle radius: {0}, coordinates: ({1}, {2})", radius, center.X, center.Y);
        }
    }
}
