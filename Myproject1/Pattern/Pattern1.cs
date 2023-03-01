using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.Pattern
{

   /* 1
      22
      333
      444 */
    internal class Pattern1
    {
        static void Main(string[] args)
        {
            for(int i=1; i <=4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }


    /* 1
       12
       123
       1234 */
    internal class Pattern2
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }


    /* 1234
       123
       12
       1 */
    internal class Pattern3
    {
        static void Main(string[] args)
        {
            for (int i = 4; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

    /* 4321
       432
       43
       4  */
    internal class Pattern4
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 4; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

    /*   *
         * o   
         * o *
         * o * o 
         * o * o *
     */
    internal class Pattern5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the row");
            int row=int.Parse(Console.ReadLine());
            for (int i = 1; i <=row ; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j == 1 ||  j == 3 || j==5  )
                    {
                       
                      Console.Write("* ");
              
                    }
                    else
                    {
                        Console.Write("o ");
                    }
                   
                }
                Console.WriteLine();
            }
        }
    }


    /*  *
        *  
    * * * * *
        * 
        * 
    */
    internal class Pattern6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the row");
            int row = int.Parse(Console.ReadLine());
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <=row; j++)
                {
                    if (j == 3 || i==3)
                    {

                        Console.Write("* ");

                    }
                    else
                    {
                        Console.Write("  ");
                    }
                   
                }
                Console.WriteLine();
            }
        }
    }

    /*  
     #####
     #   #
     #   #
     #   #
     #####

     */

    internal class Pattern7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the row");
            int row = int.Parse(Console.ReadLine());
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= row; j++)
                {
                    if (i == 1 || j==1 || i==5 || j==5)
                    {

                        Console.Write("#");

                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
        }
    }



    /*  
        * * * * *
        * *   * *
        *   *   *
        * *   * *
        * * * * * 
    */

    internal class Pattern8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the row");
            int row = int.Parse(Console.ReadLine());
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= row; j++)
                {
                    if (j == i || i==1 || i==5 || j==1 || j==5 || i+j==6 )
                    {

                        Console.Write("* ");

                    }
                    else
                    {
                        Console.Write("  ");
                    }

                }
                Console.WriteLine();
            }
        }
    }

 /*  *       *
     * *     *
     *   *   *
     *     * *
     *       *
    */     
    internal class Pattern9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the row");
            int row = int.Parse(Console.ReadLine());
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= row; j++)
                {
                    if (j==1 || j == 5 || i==j)
                    {

                        Console.Write("* ");

                    }
                    else
                    {
                        Console.Write("  ");
                    }

                }
                Console.WriteLine();
            }
        }
    }
     /* A B C D
        A     D
        A     D
        A B C D
     */
    internal class Pattern10
    {
        static void Main(string[] args)
        {
           
            for (char i = 'A'; i <= 'D'; i++)
            {
                for (char j = 'A'; j <= 'D'; j++)
                {

                    if (j == 'A' || j == 'D' || i=='A' || i=='D')
                    {
                        Console.Write(j+" ");

                    }
                    else
                    {
                        Console.Write("  ");
                    }
                 
                }
                Console.WriteLine();
            }
        }
    }
    /*
       A B C D
       A B C
       A B
       A
    */
    internal class Pattern11
    {
        static void Main(string[] args)
        {

            for (char i = 'D'; i >= 'A'; i--)
            {
                for (char j = 'A'; j <= i; j++)
                {

                    { 
                        Console.Write(j + " ");

                    }
                 

                }
                Console.WriteLine();
            }
        }
    }

    /*
    D C B A
    D C B
    D C
    D
        */

    internal class Pattern12
    {
        static void Main(string[] args)
        {

            for (char i = 'A'; i <= 'D'; i++)
            {
                for (char j = 'D'; j >= i; j--)
                {

                    {
                        
                        Console.Write(j + " ");
                       
                    }
                      


                }
                Console.WriteLine();
            }
        }
    }
}
