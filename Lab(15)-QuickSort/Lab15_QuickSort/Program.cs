using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15_QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<int, int, int> Compare = (x, y) =>
             {
                 if (x == y) return 0;
                 else if (x < y) return -1;
                 else return 1;
             };

            int[] input = new int[30];
            Random rand = new Random();

            var data = input.Select((n) => rand.Next(100));

            try
            {
                QuickSort<int> sort = new QuickSort<int>(data.ToArray(), Compare);
                sort.verify();

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
          
            }
        }
    }
}
