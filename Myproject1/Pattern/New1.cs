using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.Pattern
{
    internal class New1
    {
        static void Main(string[] args)
        {
            char ch = 'A';
            for (int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    if(j==1 || j==3 || j==5 )
                    { 
                        Console.Write(j);
                    }
                    else
                    {
                        Console.Write(ch);
                        ch++;
                    }
                   
                }
                Console.WriteLine();
            }
        }
       
    }
}
