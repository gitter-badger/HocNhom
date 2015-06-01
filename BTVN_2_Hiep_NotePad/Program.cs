using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_2_Hiep_NotePad
{
    class MyNotepad
    {
        public void Display(bool bExit = false)
        {
            while (!bExit)
            {
                //string[][] smenu = new string[5][] { // jagged array (array of arrays)
                //    new string[7] { "1. new", "2. open...", "3. save", "4. save as...", "5. page setup", "6. print...", "7. exit" },
                //    new string[11] { "1. undo", "2. cut", "3. copy", "4. paste", "5. delete", "6. find...", "7. find next", "8. replace...", "9. go to...", "10. select all", "11. time/date" },
                //    new string[2] { "1. wordwrap", "2. font..." },
                //    new string[1] { "1. status bar" },
                //    new string[2] { "1. view help", "2. about mynotepad" }
                //};

                //for (int i = 0; i < smenu.length; i++)
                //{
                //    console.writeline("---array ({0}):", i + 1);
                //    string[] innerarray = smenu[i];
                //    for (int j = 0; j < innerarray.length; j++)
                //    {
                //        console.writeline(innerarray[j] + " ");
                //    }
                //    console.writeline();
                //}
                //console.readline();
                Console.Clear();
                Console.WriteLine("* MY NOTEPAD *\n");
                Console.WriteLine("- MENU -\n");
                Console.WriteLine("Xin vui long nhap so thu tu sau do Enter de lua chon danh muc\n(VD: Nhan phim so 1 de vao menu File).\nNhan phim e roi Enter de thoat chuong trinh\n");
                Console.WriteLine("1. File");
                Console.WriteLine("2. Edit");
                Console.WriteLine("3. Format");
                Console.WriteLine("4. View");
                Console.WriteLine("5. Help\n");

                string sInput = Console.ReadLine();
                int iChoice = 0;
                bool bMenu = int.TryParse(sInput, out iChoice);
                if (sInput == "e")
                {
                    Environment.Exit(0);
                }
                else if (bMenu)
                {
                    if (iChoice > 0 && iChoice < 6)
                    {
                        switch (iChoice)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("Ban da chon menu File, vui long nhap so thu tu de lua chon thao tac tiep theo:");
                                Console.WriteLine("1. New");
                                Console.WriteLine("2. Open");
                                Console.WriteLine("3. Save");
                                Console.WriteLine("4. SaveAs");
                                Console.WriteLine("5. Exit\n");
                                Console.ReadLine();
                                if (iChoice > 0 && iChoice < 6)
                                {
                                    switch (iChoice)
                                    {
                                        case 1:
                                            New();
                                            break;
                                        case 2:
                                            Open();
                                            break;
                                        case 3:
                                            Save();
                                            break;
                                        case 4:
                                            SaveAs();
                                            break;
                                        case 5:
                                            Exit();
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("So ban nhap khong hop le. Vui long nhap so trong khoang tu 1 -> 5 tuong ung voi danh muc.");
                                }
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("Ban da chon menu Edit, vui long nhap so thu tu de lua chon thao tac tiep theo:");
                                Console.WriteLine("1. Undo");
                                Console.WriteLine("2. Cut");
                                Console.WriteLine("3. Copy");
                                Console.WriteLine("4. Paste");
                                Console.WriteLine("5. Delete");
                                Console.WriteLine("6. Find...");
                                Console.WriteLine("7. FintNext");
                                Console.WriteLine("8. Replace...");
                                Console.WriteLine("9. Go To...");
                                Console.WriteLine("10. Select All...");
                                Console.WriteLine("11. TimeDate\n");
                                Console.ReadLine();
                                if (iChoice > 0 && iChoice < 11)
                                {
                                    switch (iChoice)
                                    {
                                        case 1:
                                            Undo();
                                            break;
                                        case 2:
                                            Cut();
                                            break;
                                        case 3:
                                            Copy();
                                            break;
                                        case 4:
                                            Paste();
                                            break;
                                        case 5:
                                            Delete();
                                            break;
                                        case 6:
                                            Find();
                                            break;
                                        case 7:
                                            FindNext();
                                            break;
                                        case 8:
                                            Replace();
                                            break;
                                        case 9:
                                            GoTo();
                                            break;
                                        case 10:
                                            SelectAll();
                                            break;
                                        case 11:
                                            TimeDate();
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("So ban nhap khong hop le. Vui long nhap so trong khoang tu 1 -> 11 tuong ung voi danh muc.");
                                }
                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("Ban da chon menu Format, vui long nhap so thu tu de lua chon thao tac tiep theo:");
                                Console.WriteLine("1. WordWrap");
                                Console.WriteLine("2. Font...\n");
                                Console.ReadLine();
                                if (iChoice > 0 && iChoice < 3)
                                {
                                    switch (iChoice)
                                    {
                                        case 1:
                                            WordWrap();
                                            break;
                                        case 2:
                                            Font();
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("So ban nhap khong hop le. Vui long nhap so 1 hoac so 2 tuong ung voi danh muc.");
                                }
                                break;
                            case 4:
                                Console.Clear();
                                Console.WriteLine("Ban da chon menu View, vui long nhap so thu tu de lua chon thao tac tiep theo:");
                                Console.WriteLine("1. Status Bar\n");
                                Console.ReadLine();
                                if (iChoice == 1)
                                {
                                    StatusBar();
                                }
                                else
                                {
                                    Console.WriteLine("So ban nhap khong hop le. Vui long nhap so 1 hoac so 2 tuong ung voi danh muc.");
                                }
                                break;
                            case 5:
                                Console.Clear();
                                Console.WriteLine("Ban da chon menu Help, vui long nhap so thu tu de lua chon thao tac tiep theo:");
                                Console.WriteLine("1. View Help");
                                Console.WriteLine("2. About MyNotepad\n");
                                Console.ReadLine();
                                if (iChoice > 0 && iChoice < 3)
                                {
                                    switch (iChoice)
                                    {
                                        case 1:
                                            WordWrap();
                                            break;
                                        case 2:
                                            Font();
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("So ban nhap khong hop le. Vui long nhap so 1 hoac so 2 tuong ung voi danh muc.");
                                }
                                break;
                        }
                    }
                    
                }
                else
                {
                    Console.WriteLine("Ki tu ban nhap khong phai la so nguyen. Xin vui long nhap lai.");
                    Console.ReadLine();
                }
            }
            Console.ReadLine();
        }

        #region menuFile
        private void New()
        {
            //File Stream Input cac kieu con da dieu viet vao day
            Console.Clear();
            Console.WriteLine("New Document");
            Console.ReadLine();
        }
        private void Open() { }
        private void Save() { }
        private void SaveAs() { }
        private void Exit()
        {
            Environment.Exit(0);
        }
        #endregion

        #region menuEdit
        private void Undo() { }
        private void Cut() { }
        private void Copy() { }
        private void Paste() { }
        private void Delete() { }
        private void Find() { }
        private void FindNext() { }
        private void Replace() { }
        private void GoTo() { }
        private void SelectAll() { }
        private void TimeDate() { }
        #endregion

        #region menuFormat
        private void WordWrap() { }
        private void Font() { }
        #endregion

        #region menuView
        private void StatusBar() { }
        #endregion

        #region menuHelp
        private void ViewHelp() { }
        private void About() { }
        #endregion

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyNotepad np = new MyNotepad();
            np.Display();
        }
    }
}
