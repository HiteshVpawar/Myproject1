using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1
{
    internal class Static_overl
    {
        static void Multiplication(int num1 ,int num2)
        {
            Console.WriteLine("multiplication of num ="+(num1+num2));
        }
        static void Multiplication(int num1, int num2,int num3)
        {
            Console.WriteLine("multiplication of num =" + (num1 + num2+num3));
        }
        static void Main(string[] args)
        {
            Multiplication( 2, 3);
            Multiplication(1, 3, 5);
        }
    }
}
