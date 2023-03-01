using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.oop
{
    internal class Student
    {
        int id;
        string name;
        int s1, s2, s3;
        int total;

       int percentage;
        public void Getdata(int sid,string sname,int s1m,int s2m,int s3m)
        {
            id = sid;
            name = sname;
            s1 = s1m;
            s2 = s2m;
            s3= s3m;
        }
        public void FindPer()
        {
            total = ((s1 + s2 + s3)*100);
            percentage = (total / 300);
        }
        public void StudDetail()
        {
            Console.WriteLine("student result detail");
            Console.WriteLine("id ="+id+"sname="+name+" "+"s1 mark="+s1+" "+"s2 marks ="+s2+"s3 mark ="+s3+" "+"per of student ="+percentage+"%");
        }
        static void Main(string[] args)
        {
            Student s= new Student();
           
            s.Getdata(2,"amol", 78, 67, 55);
            s.FindPer();
            s.StudDetail();
        }
    }
}
