using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_CoBanHuongDoiTuong
{
    class Human
    {
        public int v1 { get; set; }
        public int v2 { get; set; }
        public int v3 { get; set; }
    }


    class Women:Human
    {
        public string sex = "Female";
        public string name { get; set; }

        public People child { get; set; }
        public void an()
        {
            Console.WriteLine(string.Format("{0} dang an", name));
            choi();
        }

        private void choi()
        {
            Console.WriteLine(string.Format("{0} dang choi", name));
        }

        public void ngu()
        {
            Console.WriteLine(string.Format("{0} dang ngu", name));
        }

        public void RuConNgu(People p)
        {

        }
    }
}
