using System;
using System.Threading;

namespace dz_circle
{
    class CircleGenerator
    {
        Circle[] c;

        public void generate(int countOfCircles)
        {
            c = new Circle[countOfCircles];
            float x, y, r;
            for (int i = 0; i < countOfCircles; i++)
            {
                Random rand = new Random();
                x = (float)(rand.Next(-10, 10));
                Thread.Sleep(100);
                y = (float)(rand.Next(-10, 10));
                Thread.Sleep(100);
                r = (float)(rand.Next(1, 10));
                c[i] = new Circle(r, new Point(x, y));
            }
        }

        public int calcCountOfCollision()
        {
            int count = 0;
            for (int i = 0; i < c.Length - 1; i++)
            {
                for (int j = i + 1; j < c.Length; j++)
                    if (c[i].collisionCheck(c[j]))
                        count++;
            }

            return count;
        }

        public void printCircles()
        {
            Console.WriteLine("Circles info:");
            foreach (Circle p in c)
                p.print();
        }
    }
}
