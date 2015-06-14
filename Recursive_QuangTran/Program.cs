using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_QuangTran
{
    class FunGame
    {
        public int playGame()
        {
            //Khởi tạo biến random
            Random r = new Random();
            int a = r.Next(1, 100);//random bừa 1 số, biến a là kết quả cần tìm
            Console.Write("Moi ban nhap so can tim: ");//thông báo nhập số cần tìm
            int b = int.Parse(Console.ReadLine());//Nhập số cần tìm, và convert từ string sang int
            int count = 0; // đếm số lần đoán
            //nếu số nhập vào không phải số cần tìm, thì nhập lại
            while (b != a)
            {
                if (b > a)
                {
                    Console.WriteLine("So can tim nho hon so " + b);
                }
                else
                {
                    Console.WriteLine("So can tim lon hon so " + b);
                }
                Console.Write("Moi ban nhap so can tim: ");//thông báo nhập số cần tìm
                b = int.Parse(Console.ReadLine());//Nhập lại số cần tìm, và convert từ string sang int
                count++;
            }
            return count;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.SetBufferSize(400, 500);
            //Rect r = new Rect();
            //r.drawRect(10, 10, 73, 73);
            //QMath m = new QMath();
            //Console.WriteLine(QMath.LuyThua(2, 1));
            //FunGame f = new FunGame();
            //int count = f.playGame();
            //Console.WriteLine(string.Format("Ban da doan {0} lan ", count));
            //int i = 100;
            //int j=0;
            //while (i != 1)
            //{
            //    i /= 2;j++;
            //}
            //Console.Write(j);
            //SortAlgorithm s = new SortAlgorithm();
            //int[] listNumber = s.InsertionSort(new int[] { 1, 2, 3, 5, 6, 4 });//2 1 4 3
            //for (int i = 0; i < listNumber.Length; i++)
            //{
            //    Console.Write(string.Format(",{0}", listNumber[i]));

            //}
            //    Console.WriteLine(s.count);
            //int n = 5;
            //SortAlgorithm s = new SortAlgorithm();
            //s.displayNumber(ref n);
            //Console.WriteLine("Ban dau: " + n);
            //string s1 = "Hello";
            //s.displayString(s1);
            //Console.WriteLine(s1[1]);
            // True && True = True
            // True && False = False
            // False && False = False
            
            //True || True = True
            //True || False = True
            //False || False = False

            // !True = False
            // !False = True

            // True ^ True = False (loại trừ)
            // False ^ False = False
            // True ^ False = True

            // !, (), cac phep toan &&, ||, ^
            //bool a = 3 > 4 ^ 4 > 5 || true && !false ;
            //Console.WriteLine(a);
            Rect r = new Rect();
            r.Circle(40, 40, 30);
            Console.ReadLine();
        }
    }
}
