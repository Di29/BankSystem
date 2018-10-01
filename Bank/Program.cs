using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using Mobizon;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://api.mobizon.kz/service/message/sendsmsmessage?recipient=NNNNNNNNNNN&from=PPPPPPP&text=Message+text+here%21&apiKey=KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK

            string message = "Test";
            string num = "77021568108";
            string key = "kz7d1d0bd1eb01d7c15a163be8b8c8151bbb1247259011124a340378dd7dea216aa078";
            string url = $"https://api.mobizon.kz/service/message/sendsmsmessage?recipient={num}&text={message}%21&apiKey={key}";

            SmsSender sender = new SmsSender();
            sender.GetRequest(url);


            //void addmessage(int count, string valuta)
            //{

            //}


            //void takemessage(int count, string valuta)
            //{

            //}

            //int randomnumber()
            //{
            //    return
            //}

            //bool verification()
            //{
                
            //}

            //using (var webClient = new WebClient())
            //{
            //    // Выполняем запрос по адресу и получаем ответ в виде строки
            //    var response = webClient.DownloadString(url);
            //    Console.WriteLine(response);
            //}
            Console.ReadLine();
            
        }
    }
}
