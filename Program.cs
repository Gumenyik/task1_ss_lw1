using System.Net;

namespace task1
{
    class Program
    {
     
        void write(string path)
        {
            string savePathLigh = @"D:\Save\ReadMe-LIGHT.txt";
            string changeLine = "WORD FOUND!!!";
            string line;

            StreamReader sr = new StreamReader(path);
            StreamWriter sw = new StreamWriter(savePathLigh);

            while ((line = sr.ReadLine()) != null)
            {
              
                 for (int i = 1; i < line.Length; i++)
                 {
                     if (line [i-1] == ' ' && line[i] == '-' && Char.IsLetter(line, i+1))
                     {
                        line = changeLine;
                        break;
                     }
                 }
                sw.WriteLine(line);
            }

            sw.Close();
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
