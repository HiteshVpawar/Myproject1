using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1
{
    internal class Method_overload
    {
        public void Area(float pi,int radius)
        {
            Console.WriteLine("area of circle ="+(pi*radius*radius));
        }
        public void Area(int Length,int Width)
        {
            Console.WriteLine("area of rectangle =" + (Length* Width));
        }
        public void Area(int a)
        {
            Console.WriteLine("area of square =" + (a*a));
        }
        public void Area(int Base,float height )
        {
            Console.WriteLine("area of triangle =" + (Base*height));
        }
        static void Main(string[] args)
        {
            Method_overload m = new Method_overload();
            m.Area(3.14f, 5);
            m.Area(10, 5);
            m.Area(6);
            m.Area(10, 15.5f);
        }
    }
}
