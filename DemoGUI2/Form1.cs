using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoGUI2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //creatButton(3);
            createMatrixButton(4, 4);
        }

        public void creatButton(int number)
        {
            int x = 0;
            for (int i = 0; i < number; i++)
            {
                Button b = new Button();
                b.Location = new System.Drawing.Point(x += 80, 313);
                b.Name = "btnButton1";
                b.Size = new System.Drawing.Size(75, 23);
                b.Text = "Button " + (i+1);
                //b.Click += button1_Click;
                b.Click += (object sender, EventArgs e) => {
                    MessageBox.Show(((Button)sender).Text);
                };
                b.MouseHover += button1_MouseHover;
                b.MouseLeave += button1_MouseLeave;
                this.Controls.Add(b);
            }
        }

        public void createMatrixButton(int row, int col)
        {
            int x = 0;
            int y = 200;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Button b = new Button();

                    b.Location = new System.Drawing.Point(x, y);
                    b.Name = "btnButton1";
                    b.Size = new System.Drawing.Size(75, 23);
                    b.Text = "Button " + i + j;

                    b.Click += (object sender, EventArgs e) =>
                    {
                        MessageBox.Show(((Button)sender).Text);
                    };
                    b.MouseHover += button1_MouseHover;
                    b.MouseLeave += button1_MouseLeave;
                    this.Controls.Add(b);
                    if (j == col - 1)
                    {
                        x = 0;
                        y += 23;
                    }
                    else
                    {
                        x += 80;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello");
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = Color.FromArgb(0xFF, 0x00, 0x66);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = Color.FromArgb(0x00, 0xCC, 0x00);
        }
    }
}
