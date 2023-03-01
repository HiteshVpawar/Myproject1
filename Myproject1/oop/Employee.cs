using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.oop
{
    internal class Employee
    {
        int id;
        string name;
        int sal;

        static void Main(string[] args)
        {
            Employee e;
            e = new Employee();
            e.id = 101;
            e.name = "amol";
            e.sal = 20000;
            
            Console.WriteLine(e.id+" "+e.name+" "+e.sal);
        }
    }

    internal class Car
    {
        int Model_no;
        string Car_name;
        string Car_color;
        int Car_price;
        static void Main(string[] args)
        {
            Console.WriteLine(" details of swipt car");
            Car c=new Car();
            c.Model_no = 112;
            c.Car_name = "swipt";
            c.Car_color = "white";
            c.Car_price = 850000;
            Console.WriteLine(c.Car_name+ " " + c.Model_no + " " + c.Car_color + " " + c.Car_price);

            Console.WriteLine(" details of thar car");
            c.Model_no = 2098;
            c.Car_name = "thar";
            c.Car_color = "black";
            c.Car_price = 1500000;
            Console.WriteLine(c.Car_name + " " + c.Model_no + " " + c.Car_color + " " + c.Car_price);

            Console.WriteLine(" details of scorpio car");
            c.Model_no = 223485;
            c.Car_name = "scorpio";
            c.Car_color = "red";
            c.Car_price = 1300000;
            Console.WriteLine(c.Car_name + " " + c.Model_no + " " + c.Car_color + " " + c.Car_price);

        }
    }
}
