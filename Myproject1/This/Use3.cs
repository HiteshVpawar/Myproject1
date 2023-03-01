using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.This
{
    internal class Use3
    {
        public void Getdata()
        {
            Console.WriteLine("call the show method");
            this.Show();
        }
        public void Show()
        {
            Console.WriteLine("show the data");
          
        }
    }
    class Keyword1
    {
        static void Main(string[] args)
        {
            Use3 U3 = new Use3(); 
            U3.Getdata();
        }
    }
}
