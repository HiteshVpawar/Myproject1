using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1
{
    internal class Student1
    {
        int id;
        string name;
        int m1, m2, m3, m4, m5, m6;
        int per;

        public void Getdata(int id,string name,int m1,int m2,int m3,int m4,int m5,int m6)
        {
            this.id = id;
            this.name = name;
            this.m1 = m1;
            this.m2 = m2;   
            this.m3 = m3;
            this.m4 = m4;
            this.m5 = m5;
            this.m6 = m6;   
        }
        public void Per()
        {
            int total=(m1+m2+m3+m4+m5+m6);    
            per=(total*100)/600;
           
        }
        public void Result()
        {
            if(per>=75)
            {
                Console.WriteLine("A grade");
            }
            else if(per>=55)
            {
                Console.WriteLine("B grade");
            }
            else if(per>=45)
            {
                Console.WriteLine("C grade");
            }
            else if(per>=35)
            {
                Console.WriteLine("pass");
            }
            else
            {
                Console.WriteLine("fail....better luck next time");
            }
            
        }
        public void Show()
        {
            Console.WriteLine("id="+" "+id+ "name=" + " " + name+ "m1=" + " " + m1 + "m2=" + " " + m2 + "m3=" + " " +m3 + "m4=" + " " + m4 + "m5=" + " " + m5 + "m6=" + " " + m6 + "per=" + " " + per );
        }
        static void Main(string[] args)
        {
            Student1 S1 = new Student1();
            Console.WriteLine("enter the student id");
            int id=int.Parse(Console.ReadLine());
            Console.WriteLine("enter the student name");
            string name =(Console.ReadLine());
            Console.WriteLine("enter the sub 1 mark");
            int m1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the sub 2 mark");
            int m2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the sub 3 mark");
            int m3 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the sub 4 mark");
            int m4 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the sub 5 mark");
            int m5 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the sub 6 mark");
            int m6 = int.Parse(Console.ReadLine());
           
          
            S1.Getdata(id,name,m1,m2,m3,m4,m5,m6);
            S1.Per();
            S1.Show();
            S1.Result();
        }
    }
}
