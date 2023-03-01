using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.oop
{
    internal class Product
    {
        string name;
        int prize;
        int quantity;
        int bill;

        public void Totalbill()
        {
            if(quantity>0)
            {
                bill = quantity * prize;
                Console.WriteLine("total bill of pen ="+bill);
            }
            else
            {
                Console.WriteLine("error,quantity is less");
            }
        }
        static void Main(string[] args)
        {
            Product p = new Product();
            p.name = "pen";
            p.prize = 5;
            p.quantity = 10;
            Console.WriteLine("product detail  "+"name ="+p.name+" "+"prize ="+p.prize+" "+"quantity ="+p.quantity);
            p.Totalbill();  
        }
    }
}
