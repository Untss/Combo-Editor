using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combo_Editor.Modes
{
    class SplitCombo
    {

        public static int lineCounter = 0;
        public static int maxLineCounter = 0;
        public static int fileNameCounter = 0;
        public static void edit()
        {
            Console.Clear();
            Program.printlogo();

            List<String> lines = Program.Combo;

            Console.Write(" [", Color.MediumPurple);
            Console.Write("1", Color.White);
            Console.Write("] ", Color.MediumPurple);
            Console.Write("How many lines do u want per file: ", Color.White);

            maxLineCounter = int.Parse(Console.ReadLine());

            string path = "Results/" + "Split Combos/";

            if (Directory.Exists(path))
            {
                string[] files = Directory.GetFiles(path);
                foreach(string file in files){
                    File.Delete(file);
                }
            }
            else
            {
                Directory.CreateDirectory(path);
            }


            //kinda works, only first file goes wrong ill fix later maybe :)
            foreach (string line in lines)
            {
                using(StreamWriter writer = new StreamWriter(path + "Combo_Part_" + fileNameCounter + ".txt", true))
                {
                    if (lineCounter >= maxLineCounter)
                    {
                        fileNameCounter++;
                        lineCounter = 0;
                    }
                    writer.WriteLine(line);
                    lineCounter++;
                }
            }

            returnToMenu();
        }

        public static void returnToMenu()
        {
            lineCounter = 0;
            maxLineCounter = 0;
            fileNameCounter = 0;

            Colorful.Console.Write(" [", Color.MediumPurple);
            Colorful.Console.Write("+", Color.White);
            Colorful.Console.Write("] ", Color.MediumPurple);
            Colorful.Console.Write("Done Editing! Press any button to go back to the main menu.", Color.White);
            Console.ReadKey();
            Program.menu();
        }
    }
}
