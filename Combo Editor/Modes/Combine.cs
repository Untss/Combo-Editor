using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combo_Editor.Modes
{
    class Combine
    {
        public static void edit()
        {
            Console.Clear();
            Program.printlogo();

            List<String> result = Program.Combo;

            string path = "Results/" + "Combine Combos/";
            Directory.CreateDirectory(path);
            File.WriteAllLines(path + @"\Result.txt", result);
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
