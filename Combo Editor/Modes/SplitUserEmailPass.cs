using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combo_Editor.Modes
{
    class SplitUserEmailPass
    {

        public static void edit()
        {
            Console.Clear();
            Program.printlogo();

            List<String> lines = Program.Combo;

            List<String> userCombos = new List<String>();
            List<String> emailCombos = new List<String>();

            foreach(string line in lines)
            {
                if (line.Contains(":"))
                {
                    if (line.Contains("@"))
                    {
                        emailCombos.Add(line);
                    }
                    else
                    {
                        userCombos.Add(line);
                    }
                }
            }

            string path = "Results/" + "Split User or Email  Pass/";
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

            using(StreamWriter writer = new StreamWriter(path + "UserPass.txt", true))
            {
                foreach(string line in userCombos)
                {
                    writer.WriteLine(line);
                }
            }

            using (StreamWriter writer = new StreamWriter(path + "EmailPass.txt", true))
            {
                foreach (string line in emailCombos)
                {
                    writer.WriteLine(line);
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
