using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Recursion
{
    class Program
    {
        /*
         static void range(int start, int stop)
        {
            if (start == stop)
            {
                return;
            }

            else if (start > stop)
            {
               
                Console.WriteLine(" Range = {0} ", start);

                range(start - 1, stop);
            }
            else if (start < stop)
            {
               
                Console.WriteLine(" Range = {0} ", start);
                range(start + 1, stop);

            }
        }
        */
        /*
        static string getNumberString(int n)
        {
         

                if (n == 0)
                    return "";
            else
            {
                    Console.WriteLine(" n = {0} ", n);

                getNumberString(n + -1);
                return n.ToString();

            }
            

        }
        */

            static int inc(int x)
        {
            return x + 1;
        }
        static int dec(int x)
        {
            return x - 1;
        }
        
        static int multiply(int x, int y)
        {
            if (y == 1)
            {
                return 0;
            }
            else
            {
               
                Console.WriteLine("Multiply = {0} ", x);


                
                return x  + multiply(x + x, dec(y));
           
         
            }

        }
        

        
      static int power(int x, int y)
      {
          if ( y == 0)
          {
              return 1;
          }
          else
          {



                
                return x * power( x, dec(y));


          }
      }
        static void Main(string[] args)
        {
            multiply(5, 10);

            Console.WriteLine("---------------------------------------");

            Console.WriteLine("2^5=" + power(2, 5));
            Console.WriteLine("5^18=" + power(5, 18));
            Console.WriteLine("10^10=" + power(10, 10));
            Console.WriteLine("8^7=" + power(8, 7));

            Console.ReadLine();
        }

    }
}