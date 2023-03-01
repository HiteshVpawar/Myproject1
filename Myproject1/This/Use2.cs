using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.This
{
    internal class Use2
    {
        public  Use2():this(20)
        {
         
            Console.WriteLine("call one cunstructor to anothe cunstructor");
            
        }
        public Use2(int x)//:this()
        {
            Console.WriteLine(x);  
        }
        
    }
    class Keyword
    {
        static void Main(string[] args)
        {
            Use2 U1 = new Use2();
            //Use2 U2 = new Use2(30);

        }
    }
}
