using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1._2ndwritten_test
{
    //1.	Write a program to print all numbers between 1 and 100 except the numbers which are divisible by 5or 10
    internal class Ex1
    {
        static void Main(string[] args)
        {
            for(int i= 1; i<=100; i++)
            {
                if(i%5==0 || i%10==0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    // 2.	Write a program to print all factors of given numbers

    internal class Ex2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("factor of "+n+" is");
           for(int i=1;i<=n;i++)
            {
                if(n%i==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
    //WAP to print number from 1 to 50 if number is even then print as it is and number is odd then print its square

    internal class Ex3
    {
        static void Main(string[] args)
        {
           
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                if(i%2!=0)
                {
                    int s = i * i;
                    Console.WriteLine(i+ " square ="+s);
                }
            }
        }
    }
    //4.	WAP to print fibbo series upto 20 terms
    internal class Ex4
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1,c = a + b;
            Console.WriteLine("fibonacci series");
            for (int i = 1; i <= 20; i++)
                
            {
                c = a + b;
                a = b;
                b =c;
                Console.WriteLine(b);
            }
        }
    }
    //5.	To find whether the given number is a Harshad number or not, calculate the sum of the digit of the
    //number then, check whether the given number is divisible by the sum of its digit. If yes, then given
    //number is a Harshad number.

    internal class Ex5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int temp = n;
            while(n>0)
            {
                int digit = n % 10;
                sum = sum + digit;
                n = n / 10;
            }
           if(temp%sum==0)
            {
                Console.WriteLine("given number is harshad number");
            }
            else
            {
                Console.WriteLine("not harshad");
            }
        }
    }
    /*6.	Write a program to print number from 1 to 100 such that when a number is factor of 3 and 5
    both print  “RedBlue”  and if given number is factor of only 3 the print “red” and if given number
    is factor of only 5 then “blue” otherwise the number itself*/


    internal class Ex6
    {
        static void Main(string[] args)
        {
           for(int i=1;i<100;i++)
            {
                if(i%3==0 && i%5==0)
                {
                    Console.WriteLine(i+" RedBlue");
                }
                else if(i%3==0)
                {
                    Console.WriteLine(i+" red");
                }
                else if(i%5==0)
                {
                    Console.WriteLine(i+" Blue");
                }
                else
                {
                    Console.WriteLine(i+" the number itself");
                }
            }
        }
    }
    //7.	Write Property for the class Order contain  (order_id,city,cust_name,isDelivered).


    class Order
    {
        int order_id;
        string city;
        string cust_name;
     string isDelivered;

        public void Getdata(int order_id,string city,string cust_name,string isDelivered)
        {
            this.order_id = order_id;   
            this.city = city;   
            this.cust_name = cust_name; 
            this.isDelivered = isDelivered;
        }
        public void Show()
        {
            Console.WriteLine(order_id + " " + city + " " + cust_name + " " + isDelivered);
        }
    }
    internal class Ex7
    {
        static void Main(string[] args)
        {
            Order o=new Order();
            o.Getdata(123, "nashik", "amol", "yes");
            o.Show();

        }
    }

    /*.	Write a code to check given number is Krishnamurthy number or not
    e.g 145=  1!+4!+5!
	1+24+120
	145  the original number get back is known as Krishnamurthy.   */

    class Krishnamurthy
    {
        int n = int.Parse(Console.ReadLine());
       
        public void FindNum()
        {
            int temp = n;
           
            int sum = 0;
            while(n>0)
            {
                int digit = n % 10;
                int fact = 1;
                for (int i = 1;i <= digit;i++)
                {
                    fact=fact*i;
                    

                }
                sum = sum + fact;
                n = n / 10;

            }
            if(temp==sum)
            {
                Console.WriteLine("num is krishnamurti");

            }
            else
            {
                Console.WriteLine("not krishnamurti");
            }
        }
        
    }
    internal class Ex8
    {
        
        static void Main(string[] args)
        {
            
            Console.WriteLine("enetr the number");
            Krishnamurthy k = new Krishnamurthy();
            k.FindNum();
        }
    }
}
