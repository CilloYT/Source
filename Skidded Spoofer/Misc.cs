using System;
using System.Collections.Generic;
using System.Text;

namespace Skidded_Spoofer
{
    class Misc
    {
        public static void Ascii()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("        ██████  ██ ▄█▀ ██▓▓█████▄ ");
            Console.WriteLine("      ▒██    ▒  ██▄█▒ ▓██▒▒██▀ ██▌");
            Console.WriteLine("      ░ ▓██▄   ▓███▄░ ▒██▒░██   █▌");
            Console.WriteLine("        ▒   ██▒▓██ █▄ ░██░░▓█▄   ▌");
            Console.WriteLine("      ▒██████▒▒▒██▒ █▄░██░░▒████▓ ");
            Console.WriteLine("      ▒ ▒▓▒ ▒ ░▒ ▒▒ ▓▒░▓   ▒▒▓  ▒ ");
            Console.WriteLine("      ░ ░▒  ░ ░░ ░▒ ▒░ ▒ ░ ░ ▒  ▒ ");
            Console.WriteLine("      ░  ░  ░  ░ ░░ ░  ▒ ░ ░ ░  ░ ");
            Console.WriteLine("            ░  ░  ░    ░     ░    ");
            

        }

        public static void Text(String text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n[");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("#");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("]");
            Console.Write(text);
           
        }

        
    }
}
