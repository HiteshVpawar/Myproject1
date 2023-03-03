using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.Static
{
    internal class Use4
    {
        //static cunstructor are use to initialize  static variablse
        //its call automatically
        //its call only one time
        //it can not have any modifier or parameter

        static Use4()
        {
            Console.WriteLine("hello");
        }
        public Use4(int a)
            {
            Console.WriteLine(a);
            }
        static void Main(string[] args)
        {
            Use4 u4 = new(10);
        }
    }


}
