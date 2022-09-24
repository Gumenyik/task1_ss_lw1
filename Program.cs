using System;
using System.Net;
using System.IO;
namespace task1
{
     static class Program
    {
        void Write()
        {
            string savePathLigh = @"D:\Save\ReadMe-LIGHT.txt";
            using (StreamReader sr = new StreamReader(savePath));
        } 
        static void Main()
        {
            string url = "https://mail.univ.net.ua/readme.txt";
            string savePath = @"D:\Save\readme.txt";
            WebClient client = new WebClient();
            client.DownloadFile(url, savePath);
            Console.WriteLine(savePath);
            Console.ReadLine();
        }
    }
}
