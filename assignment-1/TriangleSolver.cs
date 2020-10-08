using System;
using System.Collections.Generic;
using System.Text;

namespace assignment_1
{
   public static class TriangleSolver
    {
        public static string Analyze(int a, int b,int c)
        {




            if (a + b > c && b + c > a && c + a > b)
            {
                


                if (a ==b && b== c)
                {

                    return ("It is an equilateral triangle");
                }
                else if (a == b || a == c || b == c)
                     
                {

                   return("It is an isosceles triangle"); 
                }
                else if(a != b&& b != c)
                {

                    return("It is a scalane triangle");
                }
            }
            else
            {
                return("It is not a triangle");
               
            }
            return ("triangle");
        }



    }

}
