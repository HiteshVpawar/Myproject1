using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.written_test
{
    //WAP to print all numbers between 1 to 100 except the number which are divisible by 5 or 10
    internal class Ex1
    {
        static void Main(string[] args)
        {
          for(int i=1;i<=100;i++)
            {
                if(i%5==0 || i%10==0)
                {
                    Console.WriteLine(i);
                }
            }
       
        }
    }

    internal class Ex2
    {
        static void Main(string[] args)
        {
            int b = 0;
            {
                do
                {
                    int a = 2;
                    b++;
                    Console.WriteLine(a++);
                }
                while (b != 3);
            }

        }
    }

    // o/p=2 2 2

    internal class Ex3
    {
        static void Main(string[] args)
        {
            int i = 1,k = 1;
            while(i++<=5)
            {
                k = k * i;
            }
            Console.WriteLine("k="+k+"i="+i);
            //k=720,i=7;
        }
    }

    //WAP to check given number is spy or not
    internal class Ex4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());
            int product = 1;
            int sum = 0;

            while(n>0)
            {
                int digit = n % 10;
                sum = sum + digit;
                product=product*(digit);    
                n = n / 10;
            }
            if(sum==product)
            {
                Console.WriteLine("num is spy");
            }
            else
            {
                Console.WriteLine( "num is not spy");
            }
        }
    }

    //WAP to check num is trimorphic or not

    internal class Ex5
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());
            int cube = n * n * n;
            int temp = n;
            while(temp>0)
            {
                if(temp%10 != cube%10)
                {
                    Console.WriteLine("not triomorphic");
                    return;
                }
                temp = temp / 10;
                cube=cube / 10;
            }
            Console.WriteLine("num is triomorphic");
            
        }
    }

    /* 6) WAP to print following pattern. 
                1
	          2 2 2
            3 3 3 3 3
          4 4 4 4 4 4 4
    */

    internal class Ex6
    {
        static void Main(string[] args)
        {
            
            for(int i = 1; i <=4; i++)
            {
                for(int j=4-i;j>=1;j--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j<=2*i-1; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

        }
    }

    /*  7.WAP to print following pattern.
       *****
       ****
       ***
       **
       *
     */

    internal class Ex7
    {
        static void Main(string[] args)
        {
           
            for (int i = 5; i >=1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
               
            }

        }
    }

    /*
     *8) WAP to print following pattern. 
      1 2 3 4 5
        1 2 3 4
           1 2 3
              1 2
                1

    */

    internal class Ex8
    {
        static void Main(string[] args)
        {
            int j;
            for (int i = 5; i>=1; i--)
            {
                for (j =1; j<=i; j++)
                {
                    Console.Write(j);
                }
                for (j = i; j>= i; j--)
                {
                   
                    Console.Write(" ");
                    
                }
                Console.WriteLine();
            }

        }
    }

    // 9) Predict the output of following: 

    internal class Ex9
    {
        static void Main(string[] args)
        {
            for (int i = 5; i > 0; i--)
            {
                int mysteryInt = 100;
                mysteryInt -= i;
                Console.Write(mysteryInt+" ");


            }
        }
        // o/p =95,96,97,98,99
    }


    /* 10) Write a program to find twin prime number. (Accept two no from
user and check, if both are prime and their difference is 2 then they
are twin prime). */
    internal class Ex10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter n1");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter n1");
            int n2 = int.Parse(Console.ReadLine());
            bool isprime = true;


            for (int i = 2; i >= 0; i++)
            {
                if (n1 % i == 0)
                {
                    isprime = false;
                    break;
                }
                if (n2 % i == 0)
                {
                    isprime = false;
                    break;
                }
               
               
            }
            if (n1 - n2 == 2 || n2 - n1 == 2)
            {
                Console.WriteLine("its twin prime");
            }
            else
            {
                Console.WriteLine("not twin prime");
            }



        }

    }


    //  11) Print the Series 2 12 36 80 150 252....upto 10 terms
    internal class Ex11
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 2;

        }

    }

    //12) WAP to print number from 1 to 50 if number is even then print as it is and number is odd
    //then print negative number with its square

    internal class Ex12
    {
        static void Main(string[] args)
        {
            int Ons = 1;
            Console.WriteLine("even num");
            for (int i = 1; i <=50 ; i++)
            {
              if(i% 2 == 0)
                {
                    Console.WriteLine(i);
                }
     
            }
            Console.WriteLine("odd numbers");
             for (int i = 1; i <=50 ; i++)
            {
              
              if(i% 2 != 0)
                {
                    Ons = -(i * i);
                    Console.WriteLine(Ons);
                }
            }
        }
        
    }


    //  13) Predict the output of following: what are the value of i and j[1M]
    internal class Ex13
    {
        static void Main(string[] args)
        {
           

             int i = 1;
            while (i <= 5)
            {
                int j = 1;
                while (j <= 5)
                {
                    if (j == 2)
                    {
                        break;
                        Console.WriteLine(j);
                    }
                    j++;
                }
                Console.WriteLine(i);
            }

        }
        // o/p 1 print infinitly
    }

    // 14)WAP to print fibbonacci series upto 20 terms

    internal class Ex14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the series num");
            int n=int.Parse(Console.ReadLine());
            int a = 0, b = 1, c;
            for(int i=0;i<n;i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(b);
            }
            
        }
    
    }

    //15)1!+2!+3!+4!...n WAP a program to find sum

    internal class Ex15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the nth value");
            int n = int.Parse(Console.ReadLine());
            int fact = 1;
            int temp = n;
            int sum = 0;
            for (int i=1;i<=n;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    
                    fact = fact * i;
                    
                   
                }
                sum = sum + fact;
              
            }
            Console.WriteLine(sum);
        }

    }
}
