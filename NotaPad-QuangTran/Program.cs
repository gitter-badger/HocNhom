using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Media;
using System.IO;

namespace NotaPad_QuangTran
{
    
    class Program
    {
        public static void drawImage(string path)
        {
            Image Picture = Image.FromFile(path);
            Console.SetBufferSize((Picture.Width * 0x2), (Picture.Height * 0x2));
            FrameDimension Dimension = new FrameDimension(Picture.FrameDimensionsList[0x0]);
            int FrameCount = Picture.GetFrameCount(Dimension);
            int Left = Console.WindowLeft, Top = Console.WindowTop;
            char[] Chars = { '#', '#', '@', '%', '=', '+', '*', ':', '-', '.', ' ' };
            Picture.SelectActiveFrame(Dimension, 0x0);
            for (int i = 0x0; i < Picture.Height; i++)
            {
                for (int x = 0x0; x < Picture.Width; x++)
                {
                    Color Color = ((Bitmap)Picture).GetPixel(x, i);
                    //int Gray = (Color.R + Color.G + Color.B) / 0x3;
                    int Gray = (int)(Color.R * .3 + Color.G * .59 + Color.B * .11);
                    int Index = (Gray * (Chars.Length - 0x1)) / 0xFF;
                    Console.Write(Chars[Index]);
                }
                Console.Write('\n');
            }
            Console.SetCursorPosition(Left, Top);
            Console.Read();
        }

        public static void playMusic(string path)
        {
            SoundPlayer s = new SoundPlayer(path);
            
            s.PlayLooping();
            
            //s.Play();
        }
        static void Main(string[] args)
        {
            Program.drawImage(@"D:\2.jpg");
            //Random n = new Random();
            //while (true)
            //{
            //    Console.Beep(n.Next(10000), 500);
            //}
            //playMusic(Directory.GetCurrentDirectory() + @"\Be_What_You_Wanna.wav");
            //Console.Read();
        }
    }
}
