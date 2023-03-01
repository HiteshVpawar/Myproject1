using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1
{
    internal class test
    {
       static void Main(String[] args)
        {
            Console.WriteLine("enter the num1 annd num2");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int res = num1 + num2;
            Console.WriteLine("the additionof num1 and num2 is ="+res);
        }

    }


    //by using ternery staement find number is even odd

    internal class Terneydemo
    {
        static void Main(String[] args)
        {
            Console.WriteLine("enter the num to check even or odd");
            int num=int.Parse(Console.ReadLine());
            string str;

           str=(num%2==0) ? "even" :"odd";
            Console.WriteLine(str);
        }

    }

    class Switch1
    {
        static void Main(string[] args)
        {
            //WAC to check given charater is vowel or consonant
            Console.WriteLine("enter the char");
            char ch = Convert.ToChar(Console.ReadLine());
            switch (ch)
            {
                case 'A':
                    Console.WriteLine(ch + "is vowel");
                    break;
                case 'B':
                    Console.WriteLine(ch + "is vowel");
                    break;
                case 'I':
                    Console.WriteLine(ch + "is vowel");
                    break;
                case 'O':
                    Console.WriteLine(ch + "is vowel");
                    break;
                case 'U':
                    Console.WriteLine(ch + "is vowel");
                    break;
                default:
                    Console.WriteLine("char is consonant");
                    break;


            }
        }
    }
}
