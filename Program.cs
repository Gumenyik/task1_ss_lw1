using System;
using System.Net;
using System.IO;

namespace task1
{
    class Program
    {
        void write(string path)
        {
            string savePathLigh = @"D:\Save\ReadMe-LIGHT.txt";
            string changeLine = "WORD FOUND!!!";

            StreamReader sr = new StreamReader(path);
            
            string file = sr.ReadToEnd();
            sr.Close();
        } 
        static void Main()
        {
            Program program = new Program();
            WebClient client = new WebClient();

            string url = "https://mail.univ.net.ua/readme.txt";
            string savePath = @"D:\Save\readme.txt";
           
            client.DownloadFile(url, savePath);
            program.write(savePath);

            Console.ReadLine();
        }
    }
}
