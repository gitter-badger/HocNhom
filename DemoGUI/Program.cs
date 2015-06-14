using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace DemoGUI
{
    class Program
    {
        public void createWindowsForm()
        {
            Form f = new Form();
            f.Size = new Size(300, 400);
            f.Text = "Demo";

            Button b = new Button();
            b.Size = new Size(50, 30);
            b.Location = new Point(10, 10);
            b.Text = "Fuck me!";

            Button c = new Button();
            c.Size = new Size(50, 30);
            c.Location = new Point(30, 30);
            c.Text = "Hello!";

            b.Click += b_Click;//ClickHandler này của object b
            b.Click += b_Click1;// bao gồm 2 method xử lý là b_Click1; b_Click

            c.Click += b_Click1;//ClickHandler này của object c, method xử lý là b_Click1

            f.Controls.Add(b);
            f.Controls.Add(c);

            f.Click += b_Click1;//ClickHandler này của object f (Form), method xử lý b_Click1

            f.ShowDialog();
        }

        private void b_Click1(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(Form))
            {
                Form b = (Form)sender;
                MessageBox.Show(b.Text);
            }
            else
            {
                Button b = (Button)sender;
                MessageBox.Show(b.Text);
            }
            
            
            
            //b.Click -= b_Click;
        }

        void b_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeah!");
        }

        public delegate void PrintDataHandler(string data);
        public event PrintDataHandler PrintData;

        public void Print(string data)
        {
            Console.WriteLine("Dang dung may in de in " + data);
        }
        public void Screen(string data)
        {
            Console.WriteLine("Dang dung man hinh de hien thi " + data);
        }

        void onPrint()
        {
            if (PrintData != null)
            {
                PrintData("Quang");
            }
        }

        //public void callDelegate(PrintData printMethod)
        //{
        //    printMethod()
        //}
        static void Main(string[] args)
        {
            Program p = new Program();
            p.createWindowsForm();
            //PrintDataHandler d = new PrintDataHandler(p.Print);
            //d += p.Screen;
            //d("Quang");
            //p.PrintData += new PrintDataHandler(p.Print);
            p.PrintData += p.Print;
            //p.PrintData("Quang");
            //p.PrintData += p.Screen;
            //p.PrintData +=p_PrintData;
            //p.PrintData("Duc");
            //p.PrintData.Invoke("Duc");
            Console.ReadLine();
        }

        static void p_PrintData(string data)
        {
            Console.WriteLine(data);
        }
    }
}
