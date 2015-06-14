using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DemoGUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Form f = new Form();
            f.Width = 300;
            f.Height = 500;
            f.Text = "Hoc nhom";
            Button button1 = new Button();
            button1.Text = "Click me!";
            button1.Location = new Point(10, 10);
            button1.Click += button1_Click;
            f.Controls.Add(button1);
            f.ShowDialog();
            //Console.ReadLine();
        }

        static void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }
    }
}
