using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.Tassignment
{

   // Write a program to print even numbers from 121 to 229 using for loop.
    internal class ThrirdLec1
    {
        static void Main(string[] args)
        {
            for (int i = 121; i <= 229; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
      
    }


    //Write a program to print odd numbers from 521 to 229 using while loop. 

    internal class ThrirdLec2
    {
        static void Main(string[] args)
        {
            for (int i = 521; i >= 229; i--)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

    }

    // Write a program to show the use of break statement .

    internal class ThrirdLec3
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=10; i++)
            {
                if (i==5)
                {

                    break;
                }
                Console.WriteLine(i);
            }
        }

    }

    //Write a program to print all alphabets from a to z using for loop

    internal class ThrirdLec4
    {
        static void Main(string[] args)
        {
           for(char i='a'; i<='z';i++)
            {
                Console.WriteLine(i);
            }
        }

    }

    // Write a program to find sum of all even numbers between 1 to n. 

    internal class ThrirdLec5
    {
        static void Main(string[] args)
        {
            int sum=0;
            Console.WriteLine("enter the n number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) 
            {
                if(i%2 ==0)
                {
                    sum = sum + i;
                }
               
            }
            Console.WriteLine(sum);
        }

    }

    //Write a program to find sum of all odd numbers between 1 to n.

    internal class ThrirdLec6
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("enter the n number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 !=0)
                {
                    sum = sum + i;
                }

            }
            Console.WriteLine(sum);
        }

    }

    //Write a program to calculate product of digits of any number.
    internal class ThrirdLec7
    {
        static void Main(string[] args)
        {
            int n,digit,sum=1;
            Console.WriteLine("enter the number");
            n=int.Parse(Console.ReadLine());

            while(n>0)
            {
                digit = n%10;
                sum=sum*digit;
                n=n/10;
            }
            Console.WriteLine(sum);
        }

    }

    //Write a program to find frequency of each digit in a given integer.




    // Find all prime number between 400 to 300


    internal class ThrirdLec9
    {
        static void Main(string[] args)
        {
         
            for (int n = 400; n >= 300 ; n--)
            {
                bool isprime = true;
                for(int i=2;i<n;i++)
                {
                    if (n % i == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime == true)
                {
                    Console.WriteLine(n);
                }
            }
            
        }

    }


    //WAP to print squares from 1 to20
    internal class ThrirdLec10
    {
        static void Main(string[] args)
        {
            int k = 1 ;
             for(int i = 1; i < 20; i++)
            {
                k=i*i;
                Console.WriteLine(k);
            }
            
        }

	}


    //WAP to print table of given no

    internal class ThrirdLec11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter table number");
            int k=int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int j = i * k;
                Console.WriteLine(j) ;
              
            }

        }

    }


    //WAP to accept base and index from user and calculates power

    internal class ThrirdLec12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the base number");
            int Bnum = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the index number");
            int Inum = int.Parse(Console.ReadLine());
            int power = 1;
            int i = 1;
            while (i <= Inum)
            {
                power = power * Bnum;
                i++;
            }
            Console.WriteLine(power);
           
        }

    }

    //Print all palindrome numbers from 100 to 500


    internal class ThrirdLec13
    {
        static void Main(string[] args)
        {
            int sum = 0;
           
            for ( int n =100; n <= 500; n++)

            {
                int temp = n;
                while (n > 0)
                {

                   int  digit =n % 10;
                    sum = sum * 10 +digit;
                    n = n/ 10;



                }
                if(sum == temp)
                {
                    Console.WriteLine(sum);
                }
               

            }


        }

    }



}



