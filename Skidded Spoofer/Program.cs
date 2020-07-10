using System;

namespace Skidded_Spoofer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "TEST";
            Misc.Ascii();
            Misc.Text(" Welcome to Skidded Spoofer lmao");
            

            Misc.Text(" [1] Clean");
            Misc.Text(" [2] Spoof");
            Misc.Text(" Option: ");

            var option = Console.ReadLine();
            if (option == "1")
            {
                Console.WriteLine("Cleaning..");
                Spoof.CleanTraces();
                Console.WriteLine("Cleaned!");
            }
            else if (option == "2")
            {
                Console.WriteLine("Spoofing...");
                Spoof.SpoofHWID();
                Console.WriteLine("Succesfully Spoofed HWID!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Maybe type right next time tardy ;)");
            }

        }
    }
}
