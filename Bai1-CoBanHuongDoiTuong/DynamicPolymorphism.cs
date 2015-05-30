using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_CoBanHuongDoiTuong
{
    abstract class LoaiMeo:DongVatCoVu
    {
        public int tocdo = 40;
        public int cannang = 120;

        public void SanMoi()
        {
            Console.WriteLine("Loai meo dang san moi");
        }
        public virtual void SanChuot() {
            Console.WriteLine("San chuot dong");
        }
        public abstract void AnUong();

        public override void ChoConBu()
        {
            Console.WriteLine("Meo dang cho con bu");
        }
    }

    abstract class DongVatCoVu
    {
        public abstract void ChoConBu();
    }

    class SuTu : LoaiMeo, LoaiCa
    {
        public int cannang = 300;
        public void SanMoi()
        {
            Console.WriteLine("Su tu dang sang moi");
        }

        public override void AnUong()
        {
            Console.WriteLine("Su tu an linh duong");
        }

        public void Boi()
        {
            Console.WriteLine("Su tu dang tap boi");
        }

        public void An()
        {
            throw new NotImplementedException();
        }
    }

    class Doraemon:LoaiMeo
    {

        public override void AnUong()
        {
            Console.WriteLine("An banh ran");
        }
        public override void SanChuot()
        {
            Console.WriteLine("So chuot bo mie");
        }
    }

    class MeoCon:LoaiMeo
    {
        public override void AnUong()
        {
            Console.WriteLine("Meo dang an chuot");
        }

        public virtual void MauLong()
        {
            Console.WriteLine("Mau trang");
        }
    }

    class MeoMy:MeoCon
    {
        public override void MauLong()
        {
            //.base.MauLong();
            Console.WriteLine("Co ti mau den");
        }
    }

    class MeoDuc:MeoCon
    {
        public MeoCon c;
        public override sealed void MauLong()
        {
            Console.WriteLine("Long xu");
        }
    }

    class MeoDucBerlin:MeoDuc
    {
    }


    interface LoaiCa
    {
        string Name { get; set; }
        void Boi();
        void An();
        bool Chet();
    }
    interface SinhSan
    {
        void De();
    }
    class CaVang:LoaiCa,SinhSan
    {

        public void Boi()
        {
            Console.WriteLine("Ca vang dang boi");
        }

        public void De()
        {
            Console.WriteLine("Ca vang de trung, va thu tinh ben ngoai");
        }


        public void An()
        {
            Console.WriteLine("ca vang an com");
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }


        public bool Chet()
        {
            throw new NotImplementedException();
        }
    }

    class CaMap: LoaiCa, SinhSan
    {

        public void Boi()
        {
            Console.WriteLine("Ca map dang boi");
        }

        public void De()
        {
            Console.WriteLine("Ca map de con, thu tinh ben trong");
        }


        public void An()
        {
            Console.WriteLine("Ca map an thit uong mau");
        }
    }
}
