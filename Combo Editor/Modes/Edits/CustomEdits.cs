using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combo_Editor.Modes.Edits
{
    class CustomEdits
    {
        public static void edit()
        {
            Console.Clear();
            Program.printlogo();

            List<String> lines = Program.Combo;
            List<String> suffixes = new List<String>(File.ReadAllLines("Config/Suffixes.txt"));

            string path = "Results/" + "Custom Suffixes/";
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


            foreach(string line in lines)
            {
                foreach (string suffix in suffixes)
                {
                    string user = line.Split(':')[0];
                    string pass = line.Split(':')[1];

                    using(StreamWriter writer = new StreamWriter(path + "Results.txt", true))
                    {
                        writer.WriteLine(user + ":" + pass + suffix);
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
