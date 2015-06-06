using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace DucBTVN_Note
{
    interface INotepad {


         void save(string path, string name, string body, string author);
         void createOpen(string path, string body);
         bool validate();
         void displayMenu();
         string find(string s);
         string replace(string oldWord, string newWord);

    }
    class DucNotepad : INotepad
    {
        public void displayMenu()
        {
           bool bExit = false;
            while (!bExit)
            {
                
                Console.WriteLine("Welcome to NotePad program!");
                Console.WriteLine("Choose a number to manipulation this program.");
                Console.WriteLine("Choose `e` to exit this program.");
                Console.WriteLine("1. Create new file.");
                Console.WriteLine("2. Open file exist.");    
                Console.WriteLine("-----------------------------------------------");
                Console.Write("Your expected: ");

                String sInput = Console.ReadLine();
                int iChoice = 0;
                bool bMenu = int.TryParse(sInput, out iChoice);
                if (sInput == "e" || sInput == "E")
                {
                    Environment.Exit(0);
                }
                if (bMenu)
                {
                    if (iChoice > 0 && iChoice < 3)
                    {
                        switch (iChoice)
                        {
                            case 1:
                                Console.Write("File name: ");
                                string sPath = Console.ReadLine();

                                Console.Write("Body text: ");
                                string sBody = Console.ReadLine();
                                createOpen(sPath, sBody);
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("Choose one of these menus to handle.");
                                Console.WriteLine("1. Open to write");
                                Console.WriteLine("2. Open to find");
                                Console.WriteLine("3. Open to replace");
                                Console.WriteLine("--------------------------------------");
                                Console.Write("Your expected: ");

                                if (iChoice > 0 && iChoice < 4)
                                {
                                    switch (iChoice)
                                    {
                                        case 1:
                                            break;
                                        case 2:
                                            break;
                                        case 3:
                                            break;
                                    }
                                }
                                break;
                        }
                    }
                }
                else {
                    Console.WriteLine("Please input an integer number! Repeat input please");
                    Console.ReadLine();
                }


            }


            Console.ReadLine();
        }
        public void save(string path, string name, string body, string author) { }
        public void createOpen(string path, string body)
        {
            FileInfo fFile = new FileInfo(path);
            if (fFile.Exists)
            {
                Console.WriteLine("File is exist, please create another file");
                
            }
            else {
                fFile.Create();
                FileStream fs = new FileStream(fFile.FullName, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(body);
                sw.Close();              
            }
            
        }
        public bool validate(){
            return true;
        }
        public string find(string s){
            return "";
        }
        public string replace(string oldWord, string newWord) {
            return "";
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            DucNotepad dn = new DucNotepad();
            dn.displayMenu();
        }
    }
}
