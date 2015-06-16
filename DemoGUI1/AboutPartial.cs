using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoGUI1
{
    partial class About
    {
        public void KhoiTaoGiaoDien()
        {
            //Khởi tạo giao diện cho form
            this.Text = "Về chúng tôi";
            this.Size = new System.Drawing.Size(800, 500);

            //Tạo các control
            btn1 = new Button();
            btn1.Size = new System.Drawing.Size(60, 30);
            btn1.Location = new System.Drawing.Point(10, 10);
            btn1.Text = "Button 1";
            

            btn2 = new Button();
            btn2.Size = new System.Drawing.Size(60, 30);
            btn2.Location = new System.Drawing.Point(10, 40);
            btn2.Text = "Button 2";

            //Add sự kiện cho control
            btn1.Click += btn1_Click;
            btn1.MouseHover += btn1_MouseHover;
            btn1.MouseLeave += btn1_MouseLeave;
            btn2.Click += btn2_Click;

            //Add control vào form
            this.Controls.Add(btn1);
            this.Controls.Add(btn2);
        }

        private Button btn1;
        private Button btn2;
    }
}
