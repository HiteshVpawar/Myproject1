using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.Static
{

    class  Employee
    {
        int Eid;
        string Ename;
        static string Company_name="iris";
     public void Getdata(int Eid,string Ename)
        {
            this.Eid = Eid;
            this .Ename = Ename;    
        }
        public void Dispaly()
        {
            Console.WriteLine(Eid+" "+Ename+" "+Company_name);
        }

    }
 
    internal class Use5
    {
        static void Main(string[] args)
        {
          Employee emp = new Employee();
            
            Employee emp2 = new Employee();
            Employee emp3 =new Employee();
            emp.Getdata(101, "amol");
            emp2.Getdata(102, "abhi");
            emp3.Getdata(103, "vaibhav");
            emp.Dispaly();
            emp2.Dispaly();
            emp3.Dispaly();
        }
    }
}
