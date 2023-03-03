using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1
{
    internal class Department
    {
        public int did;
        public string dname;
        
        public Department(int did, string dname)
        {
            this.did = did;
            this.dname = dname;
        }
        public void DispalyDept()
        {
            Console.WriteLine(did+" "+dname);
        }
    }
    class Employee
    {
        int id;
        string name;
        Department dept;

        Employee(int id, string name, Department dept)
        {
            this.id = id;
            this.name = name;
            this.dept = dept;
        }   
        public void ShoeEmp()
        {
            Console.WriteLine(id+" "+name);
            dept.DispalyDept();
        }
        static void Main(string[] args)
        {
            Department d = new Department(1, "Hr");
            Employee emp = new Employee(101, "ankit", d);
            emp.ShoeEmp();
        }
    }
}
