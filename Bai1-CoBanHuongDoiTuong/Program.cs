using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_CoBanHuongDoiTuong
{
    //console application
    //References: các thư viện lập trình có sẵn của microsoft, hoặc add từ hãng thứ 3
    //Properties: file thông tin phần mềm
    //App.config: file cấu hình phần mềm, chứa các thẻ có sẵn, hoặc thẻ tự mình định nghĩa
    //Program.cs: file chính, chạy chương trình đầu tiên
    public class Program
    {
        private string Private;
        public string Public;
        internal string Internal;
        protected string Protected;
        protected internal int ProtectedInternal;
        public void Display(string Name)
        {
            Console.WriteLine(Name);
        }

        //signature
        public void Display(string Name, string Tuoi)
        {
        }

        public void Display(int Age)
        {

        }

        private string Input()
        {
            string input = Console.ReadLine();
            return input;
        }
        //Hàm mặc định Main: hàm này chạy đầu tiên, không phải do mình tạo ra, mà là thuộc cấu trúc của chương trình
        static void Main(string[] args)
        {
            #region MoDau
            ////Console là class chứa các thuộc tính (properties), phương thức (method), sự kiện (event)
            ////Write là 1 method thuộc lớp console, nhiệm vụ: in ra màn hình chuỗi truyền vào, và không xuống dòng
            ////WriteLine(): in ra màn hình chuỗi truyền vào và xuống dòng
            //Console.WriteLine("Hello World");
            //Console.WriteLine("Loc");

            ////Readline(): nhận 1 phím bất kỳ đc gõ, rồi xuống dòng, và kết thúc chương trình
            //string s = Console.ReadLine();

            //Console.WriteLine("Ket qua:" + s);

            //Console.ReadLine(); 
            #endregion

            #region Phan1
            //Program p = new Program();
            //p.Display("ket qua:" + p.Input());
            //p.Display("quang", "loc"); 
            #endregion

            #region Phan2
            People loc = new People();
            loc.Name = "Loc";
            People hiep = new People();
            hiep.Name = "Hiep";
            People duc = new People();
            duc.Name = "Duc";
            People ketqua = loc * duc + hiep * duc;// phep nhan

            Console.WriteLine("Ket qua: " + ketqua.Name);

            //Console.ReadLine(); 
            #endregion

            #region Phan3
           // SuTu s = new SuTu();
           // s.SanMoi();
           // s.AnUong();
           // s.ChoConBu();
           // s.Boi();

           //MeoCon s1 = new MeoCon();
           // s1.SanMoi();
           // s1.AnUong();
            #endregion
            #region Phan4

            //MeoCon m = new MeoMy();
            //m.MauLong();
            //m = new MeoDucBerlin();
            //m.MauLong(); 
            #endregion


            //LoaiCa c = new CaVang();
            //c.Boi();
            ////c.De();
            //c.An();

            //CaMap cm = new CaMap();
            //cm.Boi();
            //cm.De();
            //cm.An();
            CaMap cm = new CaMap();

            //trong khi điều kiện còn đúng, thì thực hiện khối lệnh
            //int i = 0;
            //while (Huong bi hoi nach == true && H bi hoi hang == true)
            //{
            //    //tam
                
            //}

            //i = 100;
            //do
            //{
            //    Console.WriteLine(i);
            //} while (i < 10);

            //for (int i = 100; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //foreach (var item in cl)
            //{
            //    Console.WriteLine(item.name);
            //}
            Console.ReadLine();
        }

        class ChildClass
        {
            public void Test()
            {
                Program p = new Program();
                
            }
        }

    }

}

namespace ns2
{

    class Test:Bai1_CoBanHuongDoiTuong.Program
    {
        public void test()
        {
            Bai1_CoBanHuongDoiTuong.Program p = new Bai1_CoBanHuongDoiTuong.Program();
            
        }
    }
}