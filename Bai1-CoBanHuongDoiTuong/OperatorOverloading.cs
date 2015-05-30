using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_CoBanHuongDoiTuong
{
    class People
    {
        public string Name;
        public static string mauDa = "Trang";

        public static People operator +(People p1, People p2)
        {
            People ketqua = new People();
            ketqua.Name = p1.Name +" "+ p2.Name + " " ;
            return ketqua;
        }

        public static People operator *(People p1, People p2)
        {
            People ketqua = new People();
            ketqua.Name = " phep nhan ";
            return ketqua;
        }

        public static People operator -(People p1, People p2)
        {
            People ketqua = new People();
            ketqua.Name = p1.Name + " " + p2.Name;
            return ketqua;
        }
    }
}
