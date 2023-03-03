using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.Encapsulation
{

    class Account1
    {
        string name;
        long anum;
        int balance;

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public long Anum
        {
            set
            {
                anum = value;
            }
            get
            {
                return anum;
            }
        }
        public int Balance
        {
            set
            {
                balance = value;    
            }
            get 
            {
                return balance; 
            } 
        }

    }
    internal class Account
    {

        static void Main(string[] args)
        {
            Account1 a = new Account1();
            a.Name = "hitesh";
            a.Anum=34987234864;
            a.Balance = 370000;

            Console.WriteLine("user name ="+a.Name);
            Console.WriteLine("user account num ="+a.Anum);
            Console.WriteLine("user account balance ="+a.Balance);
        }
    }
}
