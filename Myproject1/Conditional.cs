using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1
{
    class Switchdemo
    {
        static void Main(string[] args)
        {
            // to check num is out of 1 to 5
            Console.WriteLine("enter the num");
            int n1 = int.Parse(Console.ReadLine());
            switch (n1)
            {
                case 1:
                    Console.WriteLine(n1);
                    break;
                case 2:
                    Console.WriteLine(n1);
                    break;
                case 3:
                    Console.WriteLine(n1);
                    break;
                case 4:
                    Console.WriteLine(n1);
                    break;
                case 5:
                    Console.WriteLine(n1);
                    break;
                default:
                    Console.WriteLine("num is out of 1 to five");
                    break;
            }
        }
    }

    class Switchdemo1
    {
        static void Main(string[] args)
        {
            //WAC to check given charater is vowel or consonant
            Console.WriteLine("enter the char");
            char ch = Convert.ToChar(Console.ReadLine());
            switch (ch)
            {
                case 'a':
                    Console.WriteLine(ch + "is vowel");
                    break;
                case 'e':
                    Console.WriteLine(ch + "is vowel");
                    break;
                case 'i':
                    Console.WriteLine(ch + "is vowel");
                    break;
                case 'o':
                    Console.WriteLine(ch + "is vowel");
                    break;
                case 'u':
                    Console.WriteLine(ch + "is vowel");
                    break;
                default:
                    Console.WriteLine("char is consonant");
                    break;


            }
        }
    }


    class Switchdemo2
    {
        static void Main(string[] args)
        {
            //write a code to calculate the area of circle rectangle ,square,triangle using switch case
    
            Console.WriteLine( "select the choice of area you want to calculate circle\t rec\t squ\t tri\t");
            string str=Console.ReadLine();

            switch(str)
            {
                case "cicle":
                    double PI = 3.14;
                    Console.WriteLine("enter the raduis of circle");
                    int r = int.Parse(Console.ReadLine());
                    Console.WriteLine("area of circle is ="+(PI*r*r));
                    break;
                case "rectangle":
                    Console.WriteLine("entre the length of rectangle");
                    int l = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter the width of rectangle");
                    int w = int.Parse(Console.ReadLine());
                    Console.WriteLine("area of circle is =" + (l*w));
                    break;
                case "square":
                    Console.WriteLine("enter the side of square");
                    int s = int.Parse(Console.ReadLine());
                    Console.WriteLine("area of circle is =" + (s*s));
                    break;
                case "triangle":
                    Console.WriteLine("enter the base of triangle");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter the hight of trianhle");
                    int h = int.Parse(Console.ReadLine());
                    Console.WriteLine("area of circle is =" + ((b*h)/2));
                    break;
                    default: Console.WriteLine("cant find area");
                    break;
            }
        }
    }



    //WAC to print even number int between 1 to 20
    class Loopdemo
    {
        static void Main(string[] args)
        {
            
            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                  
                }
                
            }

        }
    }

    class Loopdemo1
    {
        static void Main(string[] args)
        {
            // display 1 t0 10 by using for loop
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }


    //WAC to count odd num in between 20 to 50
    class Loopdemo3
    {
        static void Main(string[] args)
        {
            int count = 0;
            for(int i=20; i<=50;i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }



    class Loopdemo5
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 320; i>=250; i--)
            {
                count++;
            }
            Console.WriteLine(count);
        }
    }


    //WAC to display table of given input

    class Loopdemo6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the table you want to display");
            int j =int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int l = i * j;
                Console.WriteLine(l);
            }
        }
    }



}
