using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVNtuan2Quang
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuan2 t2 = new Tuan2();
                //Bai 1. Tinh giai thua cua n
            //Console.Write("Moi ban nhap so can tinh giai thua: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(String.Format("Giai thua cua {0} la: {1}.", n, t2.TinhGiaiThua(n)));

                //Bai 2. Tinh luy thua bac. n cua a
            //Console.WriteLine(t2.TinhLuyThua(15.125, -2));

                //Bai 3. Selection Sort
            //int[] t = t2.SelectionSort(new int[] { 2, 4, 0, 1 });
            int[] t = t2.SelectionSort(new int[] { 8, 5, 2, -3,-2,-20,6, 9, 3, 1,3,-3, 4, 0, 7 });
            foreach (var item in t)
            {
                Console.Write(item + " ");
            }
            //int[] test = t2.SelectionSort(new int[]{2,4,0,1});
            //Console.WriteLine(String.Format("Min: {0}", test[0]));
            //Console.WriteLine(String.Format("Index: {0}", test[1]));

                //Bai 4. Insertion Sort
            //int[] test = t2.InsertionSort(new int[] { 2, 4, 0, 1 });
            //foreach (var item in test)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine(t2.TinhLuyThua(1, 5));
            
            Console.ReadLine();
        }
    }
}
