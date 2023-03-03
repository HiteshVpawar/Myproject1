using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.Static
{

    //static method
    internal class Use2
    {
        public static int n = 10;
        public int k = 15;
        public static void Getdata()//to call the static method is not required to create instance
                                    //by using classname.methodname we can access.
        {
            Console.WriteLine("u see static method");
            Use2 u=new Use2();  //we can not access static member but by creating instance of class we
                                 //we can accesess in static method 
            Console.WriteLine(u.k);
        }


        static void Main(string[] args)
        {
            Console.WriteLine(Use2.n);
            Use2.Getdata();

        }
    }
}
