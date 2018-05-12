using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_circle
{
    class Program
    {
        static void Main(string[] args)
        {
            CircleGenerator gen = new CircleGenerator();
            gen.generate(3);
            gen.printCircles();
            Console.WriteLine("Number of collision: {0}", gen.calcCountOfCollision());

            Console.ReadLine();
        }
    }
}
