using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1
{
    internal class Enum1
    {
        public enum season
        {
            winter,spring,summer,fall
        }
        static void Main(string[] args)
        {
            int x = (int)season.winter;
            int y = (int)season.summer;
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}
