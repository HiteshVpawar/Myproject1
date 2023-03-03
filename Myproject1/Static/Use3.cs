using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.Static
{
     static class Use3             //we declare class as static we can not inherrite it
    {                              //in static class only have static member
        static float pi = 3.14f;   // static class can not contain static member
        static int n = 5;

        static void Cube()
        {
            Console.WriteLine("cube ="+n*n*n);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Use3.pi);
            Use3.Cube();    
        }
    }
}
