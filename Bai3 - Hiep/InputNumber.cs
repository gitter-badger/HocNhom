using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BTVN_1_Hiep
{
    //Bai 1: Truyền vào 1 số, ktra xem có phải số nguyên tố (số chỉ chia hết cho nó) hay không?
    public class InputNumber
    {
        public void printResult()
        {
            Console.Write("Moi ban nhap so can kiem tra: ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (isPrime(x))
            {
                Console.WriteLine("So {0} la so nguyen to.", x);
            }
            else
            {
                Console.WriteLine("So {0} khong phai la so nguyen to.", x);
            }
        }
        public bool isPrime(int x)
        {
            if (x < 2)
                return false;
            if (x == 2)
                return true;
            for (int i = 2; i < x; i++)//i = 2; i <8; i++
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }

        //in ra n số nguyên tố, n được truyền vào
        public void displayPrimes(int n)
        {
            int count = 0;//đếm xem có bao nhiêu số nguyên tố rồi
            int prime = 1;//số nguyên tố đầu tiên được khởi tạo
            while (count < n)//nếu số lượng số nguyên tố chưa bằng n, thì tiếp tục tìm
            {
                if (isPrime(prime))
                {
                    Console.Write(", {0}", prime);
                    count++;//nếu prime là số nguyên tố, thì count + lên 1, để đếm số nguyên tố
                }
                prime++;//sau mỗi lần kiểm tra prime có phải số nguyên tố hay không, prime sẽ phải tăng lên cho lần kiểm tra tiếp theo
            }
        }

        //Nhập vào một chuỗi, và nhập vào 1 ký tự, kiểm tra ký tự ấy xuất hiện bao nhiêu lần trong chuỗi ấy
        public int checkNumberChar(string chuoiCanKiemTra, char c = '3')
        {
            int count = 0;
            for (int i = 0; i < chuoiCanKiemTra.Length; i++)
            {
                if (c == chuoiCanKiemTra[i])
                {
                    count++;
                }
            }
            return count;
        }

        public void displayArray()
        {
            //char[] mangKyTu = new char[5];
            //mangKyTu[0] = 'Q';
            //mangKyTu[1] = 'u';
            //mangKyTu[2] = 'A';
            //mangKyTu[3] = 'n';
            //mangKyTu[4] = 'g';

            //for (int i = 0; i < mangKyTu.Length; i++)
            //{
            //    Console.Write(mangKyTu[i]);
            //}

            //string[] soft8 = new string[4];
            //soft8[0] = "Hiep";
            //soft8[1] = "Quang";
            //soft8[2] = "Duc";
            //soft8[3] = "Loc";

            //Random r = new Random();
            //int i = r.Next(1, 6);
            //while (i == 1)
            //{
            //    i = r.Next(0, 4);
            //    if (i == 4)
            //        i--;
            //}

            //Console.Write("{0} xinh gai du doi", soft8[i]);
            //int j = 0;
            //while (j < soft8.Length)
            //{
            //    Console.WriteLine(soft8[j]);
            //    j++;
            //}

            //for (int i = 0; i < soft8.Length; i++)
            //{
            //    Console.WriteLine(soft8[i]);
            //}

            //int[,] mang2Chieu = new int[2, 3];
            //mang2Chieu[0, 0] = 1;
            //mang2Chieu[0, 1] = 2;
            //mang2Chieu[0, 2] = 3;
            //mang2Chieu[1, 0] = 4;
            //mang2Chieu[1, 1] = 5;
            //mang2Chieu[1, 2] = 6;

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.Write("--{0}", mang2Chieu[j, i]);
            //        if (j == 1)
            //        {
            //            Console.Write("--");
            //            Console.WriteLine("");
            //        }

            //    }
            //}

            //for (int i = mangSo.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(mangSo[i]);
            //}

            //string sex = "=";
            //switch (sex)
            //{
            //    case "man":
            //        Console.Write("Loc chuan man");
            //        break;
            //    case "woman":
            //        Console.Write("Xin chao thim Loc");
            //        break;
            //    case "gay":
            //        Console.Write("Loc ma gay thi cho no yeu");
            //        break;
            //    default:
            //        Console.Write("Khong xac dinh thi dam dau vao dit bo ma chet");
            //        break;
            //}

            //string name = "Quang";
            //if (name == "Kim")
            //{
            //    Console.Write("Xin chao Kim sieu vong 3");
            //}
            //else
            //{
            //    Console.Write("Bybye");
            //}

            string s = "Quang";
            int count = 1;
            //while (count < 10)
            //{
            //    Console.WriteLine(count + ".Xin chao Quang");
            //    if (count == 5)
            //    {
            //        count = 8;
            //        continue;
            //    }
                    
            //    count = count + 1;
            //}

            //do
            //{
            //    Console.WriteLine(count + ".Xin chao Quang");
            //    count = count + 1;
            //} while (count < 0);

            //for (int i = 10; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //List<string> Class = new List<string>{
            //    "KT1", "KT2", "CNTT1", "CNTT2"
            //};

            //foreach (var item in Class)
            //{
            //    Console.WriteLine(item);
            //}
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            int left = 30;
            int top = 20;
            Console.SetCursorPosition(left, top);
            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(left, top + i);
                for (int j = 0; j < 20; j++)
                {
                    Console.Write(" ");
                    if (j == 19)
                    {
                        Console.WriteLine(" ");
                    }
                }
            }

            //primative
            int integer;//integer32 = +- 2ty, integer64, integer16
            int a = 3; int b = 5; int c = a + b;
            double d;//.
            float f;//.
            decimal d1;

            string a1 = "Quang";
            char c1 = 'a';

            bool b1 = true || false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Bai 1: Truyền vào 1 số, ktra xem có phải số nguyên tố (số chỉ chia hết cho nó) hay không?
            InputNumber number = new InputNumber();
            number.displayArray();
            //number.isPrime(); thua
            //number.printResult();
            //number.displayPrimes(306);
            //Console.Write("Nhap vao chuoi: ");
            //string s = Console.ReadLine();
            //Console.Write("Nhap vao ky tu: ");
            //char c = char.Parse(Console.ReadLine());

            //int count = number.checkNumberChar(s, c);
            //Console.WriteLine("{0} xuat hien {1} lan trong chuoi {2}", c, count, s);
            //number.displayArray();
            //Console.Write("Quang"[0]);

            //FileStream filestr = new FileStream("D:/hocnhom.nfr", FileMode.Open, FileAccess.Read);//dieu da hieu
            //StreamReader reader = new StreamReader(filestr);
            //reader.BaseStream.Seek(0, SeekOrigin.Begin);//p1: 
            //string str = reader.ReadLine();
            //do
            //{
            //    Console.WriteLine(str);
            //    str = reader.ReadLine();
            //} while (str != null);

            //FileStream fileWriter = new FileStream("D:/hocnhom1.quang", FileMode.OpenOrCreate, FileAccess.Write);
            //StreamWriter writer = new StreamWriter(fileWriter);
            //Console.Write("Nhap vao mot chuoi: ");
            //string s = Console.ReadLine();
            //writer.WriteLine(s);
            //writer.Flush();
            //fileWriter.Close();

            //DirectoryInfo drInfor = new DirectoryInfo("D:/Setups");
            //DirectoryInfo[] thumucs = drInfor.GetDirectories();

            //for (int i = 0; i < thumucs.Length; i++)
            //{
            //    Console.WriteLine(thumucs[i].FullName);
            //}

            //FileInfo[] files = drInfor.GetFiles();
            ////Console.BackgroundColor = ConsoleColor.White;
            ////Console.Beep\ = ConsoleColor.Red;
            //for (int i = 0; i < files.Length; i++)
            //{
            //    Console.WriteLine(files[i].Name, ConsoleColor.Blue);
            //}
            Console.Beep(2000, 500);
            //while (true)
            //{
            //    Console.Beep(60, 6000);
            //}

            //if (drInfor.Exists)
            //{
            //    drInfor.CreateSubdirectory("sub_hocnhom/duc");
                
            //    DirectoryInfo drInfor1 = new DirectoryInfo("D:/hocnhom/sub_hocnhom/duc");
            //    drInfor1.Delete();
            //    Console.Write("co thu muc nay");
            //}
            //else
            //{
                
            //    Console.Write("ko co thu muc nay");
            //    drInfor.Create();
            //}
            Console.ReadLine();
        }
    }
}
