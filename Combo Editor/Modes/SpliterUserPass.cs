using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combo_Editor.Modes
{
    class SpliterUserPass
    {
        public static void edit()
        {
            Console.Clear();
            Program.printlogo();

            List<String> lines = Program.Combo;


            string path = "Results/" + "Remove Duplicates/";

            if (Directory.Exists(path))
            {
                string[] files = Directory.GetFiles(path);
                foreach(string file in files)
                {
                    File.Delete(file);
                }
            }
            else
            {
                Directory.CreateDirectory(path);
            }

            foreach (string line in lines)
            {
                if (line.Contains(":"))
                {
                    string user = line.Split(':')[0];
                    string pass = line.Split(':')[1];
                    using(StreamWriter writer = new StreamWriter(path + "Users.txt", true))
                    {
                        writer.WriteLine(user);
                    }
                    using (StreamWriter writer = new StreamWriter(path + "Passwords.txt", true))
                    {
                        writer.WriteLine(pass);
                    }
                }
            }
            returnToMenu();
        }

        public static void returnToMenu()
        {
            Colorful.Console.Write(" [", Color.MediumPurple);
            Colorful.Console.Write("+", Color.White);
            Colorful.Console.Write("] ", Color.MediumPurple);
            Colorful.Console.Write("Done Editing! Press any button to go back to the main menu.", Color.White);
            Console.ReadKey();
            Program.menu();
        }
    }
}
