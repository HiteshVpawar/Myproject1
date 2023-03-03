using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.Static
{
    //by using static create single copy of variable and share with all object
    //static variable
    internal class Use1
    {
        public static string name="hitesh";

        public void show()
        {
            Console.WriteLine(name);
        }
    }
    class NewStatic
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Use1.name);//do not need to create instance/object of the class to access the static variable
            Use1 U1 = new Use1();
            Use1 U2 = new Use1();
            Use1 U3 = new Use1();
            U1.show();
            U2.show();  
            U3.show();  
        }
    }
}
