using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace DemoGUI1
{
    partial class About: Form
    {
        public About()
        {
            this.KhoiTaoGiaoDien();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đây là button 1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đây là button 2");
        }

        private void btn1_MouseHover(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = Color.FromArgb(0x33, 0xCC, 0x00);
        }

        private void btn1_MouseLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = Color.FromArgb(0x90, 0x7C, 0xE8);
        }
    }
}
