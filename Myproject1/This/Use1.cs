using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.This
{
    internal class Use1
    {
        string name;

        public void Getdata(string name)
        {
            this.name = name;
        }
        public void Display()
        {
            Console.WriteLine(name);
        }
        static void Main(string[] args)
        {
            Use1 U1 = new Use1();
            U1.Getdata("hitesh");
            U1.Display();
        }
    }
  
}