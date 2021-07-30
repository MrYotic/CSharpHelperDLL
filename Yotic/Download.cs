using System;
using System.Collections.Generic;
using System.Diagnostics;
using Ionic.Zip;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yotic
{
    public class Download
    {
        public static void ApplicationBrowse(string link)
        {
            try
            {
                string path = "C:\\Users\\" + Environment.UserName + "\\Downloads";
                new System.Net.WebClient().DownloadFile(link, path + "\\tempApp.exe");
                Console.WriteLine("Приложение скачано,");
                Process process = new Process();
                process.StartInfo.FileName = path + "\\tempApp.exe";
                process.Start();
                Console.WriteLine("Приложение запущенно.");
            }
            catch (Exception e) { Console.WriteLine("Произошла ошибка " + e + " , в скачивании: " + link); }
        }

        public static void ApplicationBrowse(string link, bool zip)
        {
            try
            {
                string path = "C:\\Users\\" + Environment.UserName + "\\Downloads";
                new System.Net.WebClient().DownloadFile(link, path + "\\tempApp" + (zip ? "\\.zip" : "\\.exe"));
                Console.WriteLine("Приложение скачано,");
                if (zip)
                {
                    ZipFile Izip = ZipFile.Read(path + "\\tempApp");
                    Izip.ExtractAll(path);
                    Console.WriteLine("Приложение разархивированно,");
                }
                Process process = new Process();
                process.StartInfo.FileName = path + "\\tempApp.exe";
                process.Start();
                Console.WriteLine("Приложение запущенно.");
            }
            catch (Exception e) { Console.WriteLine("Произошла ошибка " + e + " , в скачивании: " + link); }
        }

        public static void ApplicationBrowse(string link, bool zip, string password)
        {
            try
            {
                string path = "C:\\Users\\" + Environment.UserName + "\\Downloads";
                new System.Net.WebClient().DownloadFile(link, path + "\\tempApp" + (zip ? "\\.zip" : "\\.exe"));
                Console.WriteLine("Приложение скачано,");
                if (zip)
                {
                    ZipFile Izip = ZipFile.Read(path + "\\tempApp");
                    Izip.Password = password;
                    Izip.ExtractAll(path);
                    Console.WriteLine("Приложение разархивированно,");
                }
                Process process = new Process();
                process.StartInfo.FileName = path + "\\tempApp.exe";
                process.Start();
                Console.WriteLine("Приложение запущенно.");
            }
            catch (Exception e) { Console.WriteLine("Произошла ошибка " + e + " , в скачивании: " + link); }
        }
    }
}
