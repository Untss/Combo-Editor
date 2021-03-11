using Combo_Editor.Combo;
using Combo_Editor.Modes;
using Combo_Editor.Modes.Edits;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combo_Editor
{
    class Program
    {
        public static List<String> Combo = new List<string>();

        static void Main(string[] args)
        {
            LoadCombo.loadCombos();
            menu();
        }

        public static void menu()
        {
            Console.Clear();
            printlogo();
            addOption(1, "Remove Duplicates");
            addOption(2, "Shuffle Combo");
            addOption(3, "Combine Combos");
            addOption(4, "Split Combos");
            addOption(5, "Split Users and passwords in 2 seperate files");
            addOption(6, "Split User:Pass / Email:Pass");
            addOption(7, "Custom Suffix | Config/Suffixes.txt");
            addOption(8, "Domain Sorter");
            addOption(9, "Email:Pass to User:Pass");
            addOption(10, "User:Pass to Email:Pass");

            Console.Write(" > ", Color.MediumPurple);
            string option = Console.ReadLine();
            if (option.Equals("1"))
            {
                RemoveDupes.edit();
            }else if (option.Equals("2"))
            {
                Shuffle.edit();
            }
            else if (option.Equals("3"))
            {
                Combine.edit();
            }
            else if (option.Equals("4"))
            {
                SplitCombo.edit();
            }
            else if (option.Equals("5"))
            {
                SpliterUserPass.edit();
            }
            else if (option.Equals("6"))
            {
                SplitUserEmailPass.edit();
            }
            else if (option.Equals("7"))
            {
                CustomEdits.edit();
            }
            else if (option.Equals("8"))
            {
                DomainSorter.edit();
            }
            else if (option.Equals("9"))
            {
                EmailToUser.edit();
            }
            else if (option.Equals("10"))
            {
                UserToEmail.edit();
            }
        }

        public static void addOption(int num, string text)
        {
            Colorful.Console.Write(" [", Color.MediumPurple);
            Colorful.Console.Write(num, Color.White);
            Colorful.Console.Write("] ", Color.MediumPurple);
            Colorful.Console.Write(text + "\n", Color.White);
        }

        public static void printlogo()
        {
            Colorful.Console.Write("| ", Color.MediumPurple);
            Colorful.Console.Write("Combo Editor\n", Color.White);
            Colorful.Console.Write("| ", Color.MediumPurple);
            Colorful.Console.Write("Made By Unts\n\n", Color.White);
        }
    }
}
