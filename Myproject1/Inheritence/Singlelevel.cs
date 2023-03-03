using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.Inheritence
{
    class Subject
    {
        protected string Book = "math";
    }
    class Math:Subject
    {
       public void Show()
        {
            Console.WriteLine(Book);
        }
    }
    internal class Singlelevel
    {
        static void Main(string[] args)
        {
            Math s1=new Math();
            s1.Show();
        }
    }
}
