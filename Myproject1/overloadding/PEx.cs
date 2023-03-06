using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.overloadding
{

    class Shape
    {
        int length;
        int width;
        float PI;
        int radius;
        public void Area(int length,int width)
        {
            Console.WriteLine("area of rectangle is ="+(length * width));
        }

        public void Area(float PI,int radius)
        {
            Console.WriteLine("area of circle is =" + (PI*radius*radius));
        }
    }
    internal class PEx
    {
        static void Main(string[] args)
        {
            Shape s = new Shape();
            s.Area(10, 15);
            s.Area(3.14f, 12);
        }
    }

    class PEx2
    {
        static void Main(string[] args)
        {

        }
    }
}
