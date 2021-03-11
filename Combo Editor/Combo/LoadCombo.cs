using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combo_Editor.Combo
{
    class LoadCombo
    {
        public static void loadCombos()
        {
            if (Directory.Exists("combos"))
            {
                string[] files = Directory.GetFiles("combos");
                foreach(string file in files)
                {
                    string[] lines = File.ReadAllLines(file);
                    foreach(string line in lines)
                    {
                        Program.Combo.Add(line);
                    }
                }
            }
        }
    }
}
