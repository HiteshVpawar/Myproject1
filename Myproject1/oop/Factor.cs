using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.oop
{
    internal class Factor
    {
       
           int n = int.Parse(Console.ReadLine()); 
        public void Getfact()
        {
            for (int i = 2; i > 0; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("enter the number");
            Factor f=new Factor();
           f.Getfact();
        }
    }
}
