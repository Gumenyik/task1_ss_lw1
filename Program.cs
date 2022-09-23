using System;
using System.Net;
using System.IO;
namespace task1
{
     static class Program
    {
        static void Main()
        {
            string url = "https://mail.univ.net.ua/readme.txt";
            string savePath = @"D:\Save\readme.txt";
            WebClient client = new WebClient();
            client.DownloadFile(url, savePath);
            Console.ReadLine();
        }
    }
}
