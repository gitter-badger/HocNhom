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
        //Chưa tính được số mũ vô tỷ
        public string TinhLuyThua(double a, int n)//a - là cơ số, n là số mũ
        {
            double result = 1;
            string lastResult = "";
            //a^n = a*a*a*a*....*a (n thua so a)
            //voi n la so am -> a^n = 1/ a^-n
            if ((a == 0 && n != 0))//kiểm tra trường hợp 0^n,  bỏ => || (a == 1 && n != 0)
            {
                if (a == 0)//nếu vào trường hợp 0^n
                {
                    if (n > 0)
                    {
                        lastResult = "0";//trả về 0
                    }
                    else //nếu n < 0
                    {
                        lastResult = "Luy thua cua 0 voi so mu a^m la khong xac dinh!";
                    }
                }
            }
            else //không phải cả 2 trường hợp 0^n,  tức là a^n (a # 0)
            {
                if(n == 0) // trường hợp a^0 = 1
                {
                    lastResult = "1";
                }
                else if(n > 0) //trường hợp n > 0: 1,2,3///
                {
                    for (int i = 0; i < n; i++) // n =3, sẽ có 3 lần nhân với chính nó
                    {
                        result = result * a;//a*1 =a, a*a = a^2, a^2*a = a^3
                    }
                    lastResult = Convert.ToString(result); //convert biến result > string
                }
                else // trường hợp n < 0
                {
                    for (int i = 0; i > n; i--)// i = 0, i++, i=1, i++ = 2;
                    {
                        result = result * a;// giờ mới chạy
                    }
                    lastResult = Convert.ToString(1 / result);//a^-n = 1/a^n
                }
            }
            return lastResult;
        }

        //Bai 3 - Sap xep day so bang thuat toan SelectionSort
        //Sắp xếp ok, nhưng đếu phải selection sort, sắp xếp đếu j nhanh hơn thuật toán gốc
        public int [] SelectionSort(int [] numbers)
        {
            int min = 0;//giá trị nhỏ nhất = 0
            int minIndex = 0;//index của số nhỏ nhất
            int count = 0;
            for (int i = 0; i < numbers.Length-1; i++)//duyệt từng mảng con, n, n-1, n-2
            {
                min = numbers[i];
                minIndex = i; count++;
                for (int j = i+1; j < numbers.Length; j++)//duyệt trong mảng con n-1
                {
                    if(numbers[j]<min)
                    {
                        min = numbers[j];
                        minIndex = j;
                    }
                    count++;
                }
                numbers[minIndex] = numbers[i];
                numbers[i] = min;
            }
            //int[] result = { min, index };
            Console.WriteLine(count);
            return numbers;
        }

        //Bai 4 - Sap xep day so bang thuat toan InsertionSort
        //chưa viết xong
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