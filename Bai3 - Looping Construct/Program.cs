using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3___Looping_Construct
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Fibonaci
    {
        private int Fn = 0;
        private int Fn1 = 1;
        private int Fn2 = 0;

        public void DisplayFibonaci()
        {
            Fn = Fn1 + Fn2;
            Console.Write(string.Format("{0}, {1}, {2}, ", Fn2, Fn1, Fn));
            
            do
            {
                Fn2 = Fn1;
                Fn1 = Fn;
                Fn = Fn2 + Fn1;
                if (Fn < 200)
                    continue;
                Console.Write(string.Format("{0}, ", Fn));
            } while (Fn <= 200);
        }

        public int Min(int a, int b)
        {
            return a < b ? a : b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Student hiep = new Student();
            //hiep.Name = "Hiep";
            //hiep.Age = 24;
            //Student loc = new Student();
            //loc.Name = "Loc";
            //loc.Age = 24;
            //Student duc = new Student();
            //duc.Name = "Duc";
            //duc.Age = 23;
            //List<Student> lstStudent = new List<Student> { 
            //    new Student{
            //        Name = "Quang Tran",
            //        Age = 25
            //        },
            //    new Student{
            //        Name = "Quang Hoang",
            //        Age = 23
            //        },
            //};
            //lstStudent.Add(hiep);
            //lstStudent.Add(loc);
            //lstStudent.Add(duc);

            //for (int i = 0; i < 100; i++)
            //{
            //    lstStudent.Add(new Student { Name = "Ten (for)" + i, Age = 23 + i });
            //}

            //int j = 0;
            //while (j < 20)
            //{
            //    lstStudent.Add(new Student { Name = "Ten (while)" + j, Age = 23 + j });
            //    j++;
            //}
            
            //foreach (var s in lstStudent)
            //{
            //    Console.WriteLine(string.Format("{0} {1}", s.Name, s.Age));
            //}

            //Console.WriteLine("--------------Do while----------------");
            //int k = 0;
            //do
            //{
            //    //loc: 0,1,2,3,4,5
            //    //duc: 0,1,2,3,4,5
            //    Console.WriteLine(k);
            //    k++;
            //} while (k < 5);
            //Console.WriteLine(string.Format("{0} {1}", duc.Name, duc.Age));
            //Console.WriteLine(string.Format("{0} {1}", loc.Name, loc.Age));
            Fibonaci f = new Fibonaci();
            f.DisplayFibonaci();
            Console.ReadLine();

        }
    }
}
