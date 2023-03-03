using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1
{
    class Menue
    {
        public int mid;
        public string mitem;
        public int mprice;

        public Menue(int mid, string mitemm, int mprice)
        {
            this.mid = mid;
            this.mitem = mitem;
            this.mprice = mprice;
        }
        public void ShowMenue()
        {
            Console.WriteLine(mid + " " + mitem + " " + mprice);
        }
        internal class Order
    {
        public int oid;
        public int quant;
        Menue m;

        public Order(int oid, int quant, Menue m)
        {
            this.oid = oid;
            this.quant = quant;
            this.m = m;
        }
        public void Show()
        {
            Console.WriteLine(oid+" "+quant);
        }
    }

    
        static void Main(string[] args)
        {
            Menue m = new Menue(102, "samosa", 20);
            m.ShowMenue();
            Order o = new Order(246, 30,m);
            o.Show();   
        }
    }
}
