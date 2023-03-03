using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.Inheritence
{
    class Product
    {
       public int price = 15000;
    }
    class LED:Product
    {
      protected  string Pname = "TV";
    }
    class Haier:LED
    {
        int size = 55;
        public void Show()
        {
            Console.WriteLine(price+" "+Pname+" "+size);
        }
    }
    internal class Multilevel
    {
        static void Main(string[] args)
        {
            Haier h = new Haier();  
            h.Show();
        }
    }
}
