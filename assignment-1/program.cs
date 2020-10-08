using System;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace assignment_1
{
   public class program

    {
        public static void  Main(string[] args)
        {
           
          
            int a,b,c;
            Console.WriteLine("enter the value of a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of c");
            
           c= Convert.ToInt32(Console.ReadLine());
            string triangle =TriangleSolver.Analyze(a, b, c);
            Console.WriteLine(triangle);
       



        }


       

    }
    }

