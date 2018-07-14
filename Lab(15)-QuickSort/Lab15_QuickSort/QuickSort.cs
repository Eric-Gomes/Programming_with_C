using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15_QuickSort
{
    class QuickSort<T> : IComparer<T>
    {

        public T[] data;
        Func<T, T, int> comp;


        public QuickSort(T[] data, Func<T, T, int> comp)
        {
            this.data = data.Clone() as T[];
            this.comp = comp;

            sort(0, this.data.Length - 1);
        }


        public int Compare(T x, T y)
        {
            return comp(x, y);
        }

        public void sort(int lo, int hi)
        {
            if (lo < hi)
            {
                int p = partition(lo, hi);
                sort(lo, p-1);
                sort(p + 1, hi);
            }
        }


        private int partition(int lo, int hi)
        {
            T pivot = data[hi];
            int i = lo;
            for (int j = lo; j <= hi - 1; j++)
            {
                if (comp(data[j], pivot) < 0)
                {
                    swap(ref data[i], ref data[j]);
                    i++;
                }
            }

            swap(ref data[i], ref data[hi]);


            return i;
   
        }

        private void print_array(int pivot)
        {
            for (int i = 0; i < pivot; i++)
            {
                Console.Write(data[i] + " ");
                
            }

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("**" + data[pivot] + "**");
       

            Console.ForegroundColor = ConsoleColor.Black;
            for (int i = pivot + 1; i < data.Length; i++)
            {
                Console.Write(data[i] + " ");
              

            }
         

        }
        private void swap(ref T p1, ref T p2)
        {
            T tmp = p1;
            p1 = p2;
            p2 = tmp;
        }

        public void verify()
        {
            if (data.Length <= 1)
            
                return;


            Console.WriteLine("Array has been sorted \n");
            

            for (int i = 0; i < data.Length - 1; i++)
            {
                if (comp(data[i], data[i+1]) >0)
                {
                    throw new Exception(String.Format("data not sorted at index {0}, {1}, {2}", i, data[i], data[i]));
                }

                Console.Write(data[i] + " ");
               
            }

            Console.Write(data[data.Length - 1] + " ");
            Console.ReadLine();
        }
     
    }

}
