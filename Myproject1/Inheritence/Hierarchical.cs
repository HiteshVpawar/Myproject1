﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.Inheritence
{
    class Engineer
    {
        public int PassoutYear = 2022;
    }
    class Civil:Engineer
    {
       public void Show()
        {
            Console.WriteLine("civil engg passout in "+PassoutYear);
        }
    }
    class Mechanical:Engineer
    {
        public void Show()
        {
            Console.WriteLine("mechanical engg passout in " + PassoutYear);
        }
    }
    class Computer:Engineer
    {
        public void Show()
        {
            Console.WriteLine("computer engg passout in " + PassoutYear);
        }
    }
    internal class Hierarchical
    {
        static void Main(string[] args)
        {
            Civil c= new Civil();
            c.Show();
            Mechanical m= new Mechanical();
            m.Show();
            Computer c1= new Computer();
            c1.Show();
        }
    }
}
