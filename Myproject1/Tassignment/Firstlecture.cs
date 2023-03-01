using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.Tassignment
{
    internal class Firstlecture1
    {
        static void Main(string[] args)
        {

            //write a program to check whether a year ia leap year or not
            Console.WriteLine("enetr the year");
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.WriteLine(year + " is leap year");

            }
            else
            {
                Console.WriteLine(year + " is not leap year");
            }
        }
    }


    //WAC to check num is divisible by 5 or 9 or not

    class EX2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the num");
            int num=int.Parse(Console.ReadLine());
            if(num%5 == 0)
            {
                Console.WriteLine(num+" is divisible by 5");
            }
            else if(num%11 == 0) 
            {
                Console.WriteLine(num + " is divisible by 11");
            }
            else
            {
                Console.WriteLine("num is not divisible by 5 or 9 or not");
            }

        }
    }

    //WAP to find max num between three numbers

    class EX3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the n1");
            int n1=int.Parse(Console.ReadLine());
            Console.WriteLine("enter the n2");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the n3");
            int n3 = int.Parse(Console.ReadLine());
            if (n1>n2)
            {
                if (n1>n3)
                {
                    Console.WriteLine("n1 is max");
                }
                
            }
            else if(n2>n1)
            {
                if (n2>n3)
                {
                    Console.WriteLine("n2 is max");
                }
                else
                {
                    Console.WriteLine("n3 is max");
                }
            }
           
        }
    }


    //check weather char is alphabet or consonant

    class EX4
    {
        static void Main(string[] args)
        {
      
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

    // to create simple calculater



    class EX5
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine( "enter a");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("enter b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("select opeator");
            Console.WriteLine(" +\t *\t /\t -\t %\t");
            char op = Convert.ToChar(Console.ReadLine());
            if (op == '+')
            {
                Console.WriteLine("Addition of a+b =" + (a + b));
            }
            else if (op == '-')
            {
                Console.WriteLine("sub of a-b =" + (a - b));
            }
            else if (op == '*')
            {
                Console.WriteLine("mul of a+b =" + (a * b));
            }
            else if (op == '/')
            {
                Console.WriteLine("div of a/b =" + (a / b));
            }
            else if (op == '%')
            {
                Console.WriteLine("mod of a%b =" + (a % b));
            }
            else
            {
                Console.WriteLine("invalid operator");
            }


            
        }
    }
     

       //to check  char is alphabet or digit 
      	class EX6
      {    
           static void Main()
          {
             char ch;
            Console.WriteLine("Enter any character: ");
            ch = Convert.ToChar(Console.ReadLine());

            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
              {
                Console.WriteLine(ch + "is an Alphabet. ");
              }
            else if (ch >= '0' && ch <= '9')
              {
                 Console.WriteLine(ch + "is a Digit. ");
              }
             else
            {
              Console.WriteLine(ch + "is a Special character.. ");
            }




        }
    }


    //WAP to calcuate employee gross sal

    class EX7
    {
        static void Main(string[] args)
        {
            double Gsal, hra, da, Bsal;
            Console.WriteLine("enetr basic sal of employee");
             Bsal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enetr da of employee");
            da = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("enetr hra of employee");
            hra = Convert.ToDouble(Console.ReadLine());

            if(Bsal<=10000)
            {
                Gsal = (da * Bsal / 100) + (hra * Bsal / 100) + Bsal;
                Console.WriteLine(Gsal);
            }
           else if (Bsal <= 20000)
            {
                Gsal = (da * Bsal / 100) + (hra * Bsal / 100) + Bsal;
                Console.WriteLine(Gsal);
            }
            else if(Bsal > 20000)
            {
                Gsal = (da * Bsal / 100) + (hra * Bsal / 100) + Bsal;
                Console.WriteLine(Gsal);
            }
            else
            {
                Console.WriteLine("enter correct employee detail");
            }

        }
    }

    //switch
    // to create simple calculater using switch operator
    class EX8
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("select opeator");
            Console.WriteLine(" +\t *\t /\t -\t %\t");
            char op = Convert.ToChar(Console.ReadLine());
            switch (op)
            {
                case '+':
                    Console.WriteLine("Addition of a+b =" + (a + b));
                    break;
                case '-':
                    Console.WriteLine("sub of a-b =" + (a - b));
                    break;
                case '*':
                    Console.WriteLine("mul of a*b =" + (a * b));
                    break;
                case '/':
                    Console.WriteLine("div of a/b =" + (a / b));
                    break;
                case '%':
                    Console.WriteLine("mod of a%b =" + (a % b));
                    break;
                default:
                    Console.WriteLine("invalid operator");
                    break;


            }
        }
    }


    //WAP to that displya the day of week corresponding to the nuber entered 

    class EX9
    {
        static void Main(string[] args)
        {

            Console.WriteLine("select day num");
            Console.WriteLine(" 1.mon\t 2.tue\t 3.wed\t 4.thur\t 5.fri\t 6.sat\t 7.sun");
            int Daynum =int.Parse(Console.ReadLine());
            switch (Daynum)
            {
                case 1:
                    Console.WriteLine("monday");
                    break;
                case 2:
                    Console.WriteLine("tuesday");
                    break;
                case 3:
                    Console.WriteLine("wednesday");
                    break;
                case 4:
                    Console.WriteLine("thursday");
                    break;
                case 5:
                    Console.WriteLine("friday");
                    break;
                case 6:
                    Console.WriteLine("saturday");
                    break;
                case 7:
                    Console.WriteLine("sunday");
                    break;
                default:
                    Console.WriteLine("invalid daynum");
                    break;


            }
        }
    }



    //WAP to that displya the day of week corresponding to the nuber entered 

    class EX10
    {
        static void Main(string[] args)
        {

            Console.WriteLine("select day num");
            Console.WriteLine(" 1.mon\t 2.tue\t 3.wed\t 4.thur\t 5.fri\t 6.sat\t 7.sun");
            int Daynum = int.Parse(Console.ReadLine());
            switch (Daynum)
            {
                case 1:
                    Console.WriteLine("monday");
                    break;
                case 2:
                    Console.WriteLine("tuesday");
                    break;
                case 3:
                    Console.WriteLine("wednesday");
                    break;
                case 4:
                    Console.WriteLine("thursday");
                    break;
                case 5:
                    Console.WriteLine("friday");
                    break;
                case 6:
                    Console.WriteLine("saturday");
                    break;
                case 7:
                    Console.WriteLine("sunday");
                    break;
                default:
                    Console.WriteLine("error,day does not exist");
                    break;


            }
        }
    }


    //WAP to enter number between  1 to 5 and print in word

    class EX11
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter  num");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                default:
                    Console.WriteLine("error,invalid num");
                    break;


            }
        }
    }


    //find the area

    class EX12
    {
        static void Main(string[] args)
        {
            //write a code to calculate the area of circle rectangle ,square,triangle using switch case
            
            Console.WriteLine("select the choice of area you want");
            string str = Console.ReadLine();

            switch (str)
            {
                case "cicle":
                    double PI = 3.14;
                    Console.WriteLine("enter the raduis of circle");
                    int r = int.Parse(Console.ReadLine());
                    Console.WriteLine("area of circle is =" + (PI * r * r));
                    break;
                case "square":
                    Console.WriteLine("enter the side of square");
                    int s = int.Parse(Console.ReadLine());
                    Console.WriteLine("area of square is =" + (s * s));
                    break;
                case "triangle":
                    Console.WriteLine("enter the base of triangle");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter the hight of trianhle");
                    int h = int.Parse(Console.ReadLine());
                    Console.WriteLine("area of right angle triangle is =" + (1 / 2) * (b * h));
                    break;
                case "rectangle_cir":
                    Console.WriteLine("entre the length of rectangle");
                    int l = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter the width of rectangle");
                    int w = int.Parse(Console.ReadLine());
                    Console.WriteLine("area of a rectangle circumference =" + 2*(l + w));
                    break;
               default:
                    Console.WriteLine("cant find area");
                    break;
            }
        }
    }
}
