using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.Inheritence
{


    class Animal
    {
        public void getdata()
        {
            Console.WriteLine("animal eating food");
        }
    }
    class Dog:Animal
    {
        public void show()
        {
            base.getdata();  //use of base keyword
            Console.WriteLine("dog eat biscuits");
        }
    }
    class Babydog:Animal
    {
        public void display()
        {
           
            Console.WriteLine("babydog dring milk");

        }
    }
    internal class Base1
    {
        static void Main(string[] args)
        {
            Dog d=new Dog();
             d.show();
            Babydog b=new Babydog();
            b.display();
        }
    }
}
