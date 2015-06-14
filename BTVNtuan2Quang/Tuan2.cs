using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVNtuan2Quang
{
    class Tuan2
    {
        //Bai 1 - Tinh giai thua khong dung giai thuat de quy
        public int TinhGiaiThua(int n)//n! = n*(n-1)*(n-2)*...*1;
        {
            int result = 0;
            if (n == 0)
            {
                result = 1;
            }
            else
            {
                result = n;
                while (n > 1)
                {
                    n--;
                    result = result * n;
                }
            }
            return result;
        }

        //Bai 2 - Tinh luy thua khong dung giai thuat de quy
        public string TinhLuyThua(double a, int n)
        {
            double result = 1;
            string lastResult = "";
            //a^n = a*a*a*a*....*a (n thua so a)
            //voi n la so am -> a^n = 1/ a^-n
            if ((a == 0 && n != 0) || (a == 1 && n != 0))
            {
                if (a == 0)
                {
                    if (n > 0)
                    {
                        lastResult = "0";
                    }
                    else
                    {
                        lastResult = "Luy thua cua 0 voi so mu a^m la khong xac dinh!";
                    }
                }
                else
                {
                    lastResult = "1";
                }
            }
            else
            {
                if(n == 0)
                {
                    lastResult = "1";
                }
                else if(n > 0)
                {
                    for (int i = 0; i < n; i++)
                    {
                        result = result * a;
                    }
                    lastResult = Convert.ToString(result);
                }
                else
                {
                    for (int i = 0; i < -n; i++)
                    {
                        result = result * a;
                    }
                    lastResult = Convert.ToString(1 / result);
                }
            }
            return lastResult;
        }

        //Bai 3 - Sap xep day so bang thuat toan SelectionSort
        public int [] SelectionSort(int [] numbers)
        {
            int min = 0;
            int minIndex = 0;
            for (int i = 0; i < numbers.Length-2; i++)
            {
                min = numbers[i];
                minIndex = i;
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if(numbers[j]<min)
                    {
                        min = numbers[j];
                        minIndex = j;
                    }
                }
                numbers[minIndex] = numbers[i];
                numbers[i] = min;
            }
            //int[] result = { min, index };
            return numbers;
        }

        //Bai 4 - Sap xep day so bang thuat toan InsertionSort
        public int[] InsertionSort(int[] listNumber)
        {
            //int[] sortedList = listNumber;
            int temp = 0;
            for (int i = 0; i < listNumber.Length; i++)
            {
                temp = listNumber[i];
                int j = i + 1;
                while ((listNumber[j] < listNumber[j - 1]) && (j<(listNumber.Length-1)))
                {
                    temp = listNumber[j];
                    listNumber[j] = listNumber[j - 1];
                    j++;
                }
                listNumber[j] = temp;
            }
            return listNumber;
        }
    }
}