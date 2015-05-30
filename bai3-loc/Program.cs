using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3_loc
{
    class Chanle1432
    {
        public int Sonhap = 0;
      
    }


    class Program
    {

        static void Main(string[] args)
        {
            string xnhap; //Tạo biến để nhập ký tự mong muốn kiểu chuỗi.
            Console.Write("Nhap x để thoat. Nhap ky tu bat ky de bat dau ktra: ");//Hiển thị ra thông báo hướng dẫn ng dùng nhập ký tự
            xnhap = Console.ReadLine(); // Nhập ký tự bất kỳ từ bàn phím
            while (xnhap  != "x") //Vòng lặp, nếu chương trình nhập x, chương trình thoát. Ngược lại vào trong vòng lặp.
            {
                Chanle1432 s = new Chanle1432(); //Khai báo biến
                Console.Write("Nhap so ban muon ktra: "); //In ra thông báo
                s.Sonhap = Convert.ToInt32(Console.ReadLine()); // Truyền dữ liệu nhập từ bàn phím và biến. Và là kiểu số nguyên. 
                if (s.Sonhap % 2 == 0) // Ktra nếu số chia hết cho 2 thì là số chẵn, ngược lại là lẻ
                {
                    Console.WriteLine("So bạn nhap la so chan"); //thông báo nếu số nhập chia hết cho 2
                }

                else // ngược lại
                {
                    Console.WriteLine("So ban nhap la so le"); //Thông báo nếu số nhập không chia hết cho 2
                }
                Console.Write("Nhap x để thoat. Nhap ky tu bat ky de bat dau ktra: ");//Thông báo hướng dẫn người dùng nhập ký tự
                xnhap = Console.ReadLine(); // Nhập ký tự, truyền vào biến.
            }


          
        }
    }
}
