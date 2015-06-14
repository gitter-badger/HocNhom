using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Duc
{
    class Program
    {
        static void Main(string[] args)
        {
            SelectionSort s = new SelectionSort();
            InsertionSort ins = new InsertionSort();
            int[] a = { 2, 4, 3, 7, 5, 6 };
            
            for (int i = 0; i < a.Length; i++)
            {
                ins.SortInsertion(a);
                  
                Console.Write(a[i] + ", ");
            }
            Console.ReadLine();

        }
    }
}
