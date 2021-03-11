using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combo_Editor.Modes
{
    class DomainSorter
    {

        public static void edit()
        {
            Console.Clear();
            Program.printlogo();

            List<String> lines = Program.Combo;
            List<String> domains = new List<String>(File.ReadAllLines("Config/Domains.txt"));

            string path = "Results/" + "Domain Sorter/";
            if (Directory.Exists(path))
            {
                string[] files = Directory.GetFiles(path);
                foreach (string file in files)
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
                foreach(string domain in domains)
                {
                    if (line.Contains(domain))
                    {
                        File.WriteAllText(path + domain + ".txt", line);
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
