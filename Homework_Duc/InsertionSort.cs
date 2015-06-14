using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Duc
{
    class InsertionSort
    {
        public void SortInsertion(int[] a) {
            for (int i = 1; i < a.Length; i++)
            {
                int temp = a[i];
                int j = i;
                while (j>0 && a[j - 1] > temp)
                {
                    a[j] = a[j-1];
                    j--;
                    
                }

                a[j] = temp;
            }
        }

    }
}
