using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1
{
    internal class CunsOverl
    {

        CunsOverl(int a,int b,int c)
        {
            Console.WriteLine("addition of numbers ="+(a+b+c));
        }
        CunsOverl(int a,int b)
        {
            Console.WriteLine("sub of numbers ="+(a-b));
        }
        CunsOverl(int a,int b,float c)
        {
            Console.WriteLine("mul of numbers ="+(a*b*c));
        }
        static void Main(string[] args)
        {
            CunsOverl c = new CunsOverl(3,4,6);
            CunsOverl c1 = new CunsOverl(7,3);
            CunsOverl c2 = new CunsOverl(2,5,9);
  
        }
    }
}
