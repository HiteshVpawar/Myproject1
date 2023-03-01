using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.WhileLoop
{
    internal class Whileloop1
    {
        //count digit
        static void Main(string[] args)
        {
            Console.WriteLine("enter the num");
            int num=int.Parse(Console.ReadLine());
            int sum = 0;
            int count=0;
            while(num>0)
            {

                int digit = num % 10;
                sum=sum+digit;  
                num=num/10;
                count++;
                
            }
            Console.WriteLine(count);
        }
    }


    //calculate the avg of digite from the num

    internal class Whileloop2
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("enter the num");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            int avg = 0;
            int sum = 0;
            
            while (num > 0)
            {

              int digit = num % 10;
                sum = sum + digit;
                num = num / 10;
                count++;
                avg = (avg + digit);

            }
            
            Console.WriteLine("avg of num"+ (avg/count));
            Console.WriteLine(count);
        }
    }

    //to check num is pallindrome or not
    
    internal class Whileloop3
    {

        static void Main(string[] args)
        {
            Console.WriteLine("enter the num");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int numcopy = num;
            while (num > 0)
            {

                int digit = num % 10;
                sum = (sum*10)+digit;  
                num = num / 10;



            }
            if(sum==numcopy)
            {
                Console.WriteLine("num is palindrome");
            }
            else
            {
                Console.WriteLine("number is not palindrome");
            }

        }
    }

    //to check number is armstrong or not


    internal class Whileloop4
    {

        static void Main(string[] args)
        {
            Console.WriteLine("enter the num");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int numcopy = num;
            while (num > 0)
            {

                int digit = num % 10;
                sum = sum+(digit*digit*digit);
                num = num / 10;

            }
            if (sum == numcopy)
            {
                Console.WriteLine("num is armstrong");
            }
            else
            {
                Console.WriteLine("number is not armstrong");
            }

        }
    }


    //WAC to print even number int between 1 to 20 by using while loop
    class Whileloop5
    {
        static void Main(string[] args)
        {
            int i = 0;
           while(i<=10)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);

                }
                i++;
            }

        }
    }


    // display 1 t0 10 by using while loop
    class Whileloop6
    {
        static void Main(string[] args)
        {
            int i = 1;
           while(i<=10)
            {
                Console.WriteLine(i);
                i++;
            }
            
        }
    }

    //WAC to count odd num in between 20 to 50 using while loop
     class Whileloop7

    {
        static void Main(string[] args)
        {
            int count = 0;
            int i = 20;
            while( i <= 50)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    count++;
                }
                i++;
            }
            Console.WriteLine(count);
        }
    }

    //WAC to print number between 320 to 250 using while loop
    class Whileloop8
    {
        static void Main(string[] args)
        {
            int count = 0;
            int i = 320;
            while ( i >= 250)
            {
                Console.WriteLine(count);
            }
            i--;
        }
    }

    //WAC to display table of given input
    class Whileloop9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the table you want to display");
            int j = int.Parse(Console.ReadLine());
            int i = 1;
            while(i <= 10)
            {
                int l = i * j;
                Console.WriteLine(l);
                i++;
            }
          
        }
    }


    internal class Whileloop10
    {

        static void Main(string[] args)
        {
            int sum = 0;
            int temp;
            for (int n = 100; n < 300; n++)
              
            {
                 temp = n;
               while(n > 0)
                {
                    
                    int r = n % 10;
                    sum = sum * 10 + r;
                     n = n / 10;
                }
                if(sum==temp)
                    Console.WriteLine(sum);

            }
           

        }
    }

    class DoWhile
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value of a");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("enter the value of b");
            int b=int.Parse(Console.ReadLine());
            Console.WriteLine("+\t -\t *\t /\t");
            char c;
            do
            {
                Console.WriteLine("select choice");
                char ch = Convert.ToChar(Console.ReadLine());
                switch (ch)
                {
                    case '+':
                        Console.WriteLine("addition of a and b is =" + (a + b));
                        break;
                    case '-':
                        Console.WriteLine("sub of a and b is =" + (a - b));
                        break;
                    case '*':
                        Console.WriteLine("mul of a and b is =" + (a * b));
                        break;
                    case '/':
                        Console.WriteLine("div of a and b is =" + (a / b));
                        break;
                    default:
                        Console.WriteLine("enter correct choice");
                        break;
                }
                Console.WriteLine("if you want to continue....");
                c = Convert.ToChar(Console.ReadLine());
            }
            while (c == 'y' || c == 'Y');
        }
    }
}
