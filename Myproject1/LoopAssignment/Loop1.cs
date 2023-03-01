using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.LoopAssignment
{

    //1.	WAP to print even numbers from 121 to 229 using do-while loop. 
    internal class Loop1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the statrting number n");
            int n = int.Parse(Console.ReadLine());

            while (n <= 229)
            {
                if(n % 2==0)
                {
                    Console.WriteLine(n);
                }
                n++;
            }
        }
    }

    //2.	 WAP to show the use of break statement(in for loop)

     
     class Loop2
    {
        static void Main(string[] args)
        {
            for(int i=0;i<10;i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }

    //3.	Write a program to print all alphabets from a to z. - using  for loop

    class Loop3
    {
        static void Main(string[] args)
        {
            for (char i = 'a'; i <='z'; i++)
            {
                Console.WriteLine(i+" ");
            }
        }
    }

    //4.	 Write a  program to find sum of all even numbers between 1 to n. 


    class Loop4
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("enter the nth number");
            int n=int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if(i%2==0)
                {
                    sum = sum + i;
                }
                
            }
            Console.WriteLine("sum of 1 to nth even number"+sum);
        }
    }

    //5.	 Write a program to find sum of all odd numbers between 1 to n.

    class Loop6
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("enter the nth number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    sum = sum + i;
                }

            }
            Console.WriteLine("sum of 1 to nth odd number =" + sum);
        }
    }


    // 6.	 Write a  program to count number of digits in any number

    class Loop7
    {
        static void Main(string[] args)
        {
            int sum = 0, count = 0 ;
            Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());
       
            while(n>0)
            {
               
                n = n / 10;
                count++;
                
            }
            Console.WriteLine(" number of digit n is ="+count);
        }
    }
    //Write a  program to calculate product of digits of any number.

    class Loop8
    {
        static void Main(string[] args)
        {
            int product=1;
            Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());
           
            while( n>0)
            {
                int digit = n % 10;
                n=n/ 10;
                product = product * digit;
            }
            Console.WriteLine(product);
        }
    }

    //9.	Find all prime number between 400 to 300;

    class Loop9
    {
        static void Main(string[] args)
        {
            for(int n = 400; n >= 300; n--)
            {
                bool isprime = true;
                for(int i=2;i<n;i++)
                {
                    if(n%i==0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if(isprime==true)
                {
                    Console.WriteLine(n);
                }
            }
        }
    }


    //1.	Write a program in  to display the first 10 terms of the following series:
    // 10, 20, 30, 40, 


    class Loop10
    {
        static void Main(string[] args)
        {
            int n = 10;
            Console.WriteLine("series of number");
            for (int i = 1; i <= 10; i++)
            {
              int  series = (n * i);
                Console.WriteLine(series);
            }
        }
    }

    //15.	check no is palimdrom or not

    class Loop11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the num");
            int n=int.Parse(Console.ReadLine());
            int temp = n;
            int sum = 0;
            while (n>0)
            {
                int digit= n % 10;
                sum = sum * 10 + digit;
                n = n / 10;

            }
            if(sum == temp)
            {
                Console.WriteLine("num is palindrom");

            }
            else
            {
                Console.WriteLine("not palindrome");
            }
        }
    }

    /*  16.	check no is automorphic or not
    input n=25
      output Automorphic
    as 25*25=625      */

    class Loop12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the num");
            int n = int.Parse(Console.ReadLine());
            int temp = n;
            int product = 1;
            int j=n+1;
           
            while(n<=j)
            {
                product=product * n;
                j--;
                
            }
            Console.WriteLine(product);
       
            int digit = 1;
            int k = product+1;
            while(product<k)
            {
                digit= product % 100;
                k--;

            }
            if(temp == digit)
            {
                Console.WriteLine("num is atomorphic");
            }
            else
            {
                Console.WriteLine("no is not atomorphic");
            }
        }
    }

    //
    class Loop13
    {
        static void Main(string[] args)
        {
           for(int i=1;i<=6;i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }

    /*
               *
             * *
           * * *
         * * * *
       * * * * *
     * * * * * *
*/

    class Loop14
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                   

                }
                Console.WriteLine();
               
            }
        }
    }
}
