using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.nested
{
      //WAC to calculate sum of prime number in between 1 to 10
    internal class Nested1
    {
        static void Main(string[] args)
        {
            int sum = 0;
           for(int n = 1; n <=10 ; n++)
            {
                bool isPrime = true;
               
                for (int i =2 ; i <n; i++)
                {
                     if(n %i==0)
                    {
                        isPrime = false;    
                        break;
                    }
                   
                }
                if (isPrime == true)
                {
                    sum = sum + n;
                   
                }
                
            }
            Console.WriteLine(sum);
        }
        
    }

    //WAC to catculate the sum of factorial between 1 to 5
    internal class Nested2
    {
        static void Main(string[] args)
        {
            int fact  = 1;
            int sum = 0;
            for(int n = 1; n <=5 ; n++)
            {
                for(int i=1;i<=n;i++)
                {
                    fact = fact * i;
                    sum = sum + fact;
                }
            }
            Console.WriteLine(sum);
        }
    }


    //WAC to dispay tables of number between 1 to 5

    class Nested3
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=10;i++)
            {
                for(int j=1;j<=5;j++)
                {
                    int k = i * j;
                    Console.Write(k+" ");
                }
                Console.WriteLine();
            }
        }
    }

    //WAC to check weather number krishnamurti or not

    class Nested4
    {
        static void Main(String[] args)
        {
            Console.WriteLine("enter the num");
            int n = int.Parse(Console.ReadLine());
            int sum= 0;
            int temp = n;
            while (n>0)
            {
            
                int digit = n % 10;
                {
                   
                    int fact = 1;
                    
                    for(int i=1;i<=digit;i++ )
                    {
                        fact = fact * i;
                       
                    }
                    sum = sum + fact;
                    n = n / 10;
                }
            }
            if (sum == temp)
                Console.WriteLine(sum + "= number is krishnamurti");
            else
                Console.WriteLine(sum + "= is not krishnamurti");
        }
    }


    // Write a code to check number is disarium or not

  class Nested5
    {
        static void Main(String[] args)
        {
            Console.WriteLine("enter the num");
            int n=int.Parse(Console.ReadLine());
            int count = 0;
            int temp = n;
            while(n>0)
            {
                count++;
                n=n / 10;
            }
            Console.WriteLine(count);

            int digit = n % 10;
        }
    }

    // find power
    class Nested6
    {
        static void Main(String[] args)
        {
            Console.WriteLine("enter the base n");
            int Bn = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the indexer");
            int In=int.Parse(Console.ReadLine());

            int power = 1;
           for(int i=1;i<=In;i++)
            {
                power = power * Bn;
                
            }
            Console.WriteLine(power);
        }
    }
}
