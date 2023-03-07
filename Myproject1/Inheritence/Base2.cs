using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.Inheritence
{

    class Bike
    {
        public string name="pulsar";
        public Bike()
        {
            Console.WriteLine("detail of pulsar bike.....");
        }   
        public void Show()
        {
            Console.WriteLine("most bought bike in india");
        }
    }
    class Pulsar:Bike
    {
        int milage=80;
        public void Show()
        {
            base.Show();
            Console.WriteLine(base.name+" "+milage);
        }
    }
    internal class Base2
    {
        static void Main(string[] args)
        {
            Pulsar p = new Pulsar();
            p.Show();
        }
    }
}
