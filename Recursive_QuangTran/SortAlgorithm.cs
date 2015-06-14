using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_QuangTran
{
    class SortAlgorithm
    {
        private void swap(ref int a,ref int b)
        {
            int tempt = a;
            a = b;
            b = tempt;
        }
        public int count { get; set; }
        //SelectionSort
        public int[] SelectionSort(int[] listNumber)
        {
            int min = 0;
            for (int i = 0; i < listNumber.Length; i++)//lặp mảng n
            {
                for (int j = i + 1; j < listNumber.Length; j++)//lặp mảng con n-1
                {
                    if (listNumber[j] < listNumber[i])//nếu tìm thấy số nhỏ nhất trong mảng con, thì đổi nó về vị trí đầu tiên trong mảng con
                    {
                        min = j;
                    }
                    else
                    {
                        min = i;
                    }
                    this.count++;
                    swap(ref listNumber[i],ref listNumber[min]);
                }
                this.count++;
            }
            return listNumber;
        }

        //InsertionSort
        public int[] insert(int[] listNumber, int rightIndex, int value) //1,2,3,5,6,4
        {
            //
            for (int j = rightIndex-1; j >= 0; j--)
            {
                if (listNumber[j] > value)
                {
                    listNumber[rightIndex] = listNumber[j];
                    rightIndex--;
                    if (j == 0)
                    {
                        listNumber[rightIndex] = value;
                    }
                }
                else
                {
                    listNumber[rightIndex] = value;
                    return listNumber;
                }
            }
            return listNumber;
        }
        public int[] InsertionSort(int[] listNumber)
        {
            for (int i = 0; i < listNumber.Length-1; i++)
            {
                insert(listNumber, i+1, listNumber[i+1]);
            }
            return listNumber;
        }

        public void displayNumber(ref int number)// int number = gia tri truyen vao
        {
            number += 5;
            Console.WriteLine(number);
        }
        public void displayString(string s)
        {
            s += " Quang";
            Console.WriteLine(s);
        }
    }
}
