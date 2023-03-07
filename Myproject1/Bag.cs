using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1
{
    class Nib
    {
        int price;
      public  Nib(int price)
        {
            this.price = price;
        }   
        public void Nibdetails()
        {
            Console.WriteLine("nib detaila"+price);
        }
    }
    class Pen
    {
        string color;
        string name;
        string type;
        Nib nib;
       
       public Pen(string color, string name, string type, Nib nib)
        {
            this.color = color;
            this.name = name;
            this.type = type;
            this.nib = nib;
           
        }
        public void DisplayPenD()
        {
            Console.WriteLine("pen Details ="+color+" "+name+" "+type);
            nib.Nibdetails();
        }
    }
    internal class Bag
    {
        string bag_name;
        string bag_color;
        int price;
        Pen pen;
        Bag(string  bag_name, string bag_color, int price, Pen pen)
        {
            this.bag_name = bag_name;
            this.bag_color = bag_color;
            this.price = price;
            this.pen = pen;
        }   
        public void showDetail()
        {
            Console.WriteLine("bag details ="+bag_name+" "+bag_color+" "+price);
            pen.DisplayPenD();
        }

        static void Main(string[] args)
        {
            Nib n = new Nib(30);
            Pen p = new Pen("blue","nataraj","jel",n);
            Bag b = new Bag("arbanic", "white", 500,p);
            b.showDetail();
          
        }
    }
}
