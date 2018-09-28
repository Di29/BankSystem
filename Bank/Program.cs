using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://api.mobizon.kz/service/message/sendsmsmessage?recipient=NNNNNNNNNNN&from=PPPPPPP&text=Message+text+here%21&apiKey=KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK

            string message = "Test";
            string num = "77081762343";
            string key = "kz7d1d0bd1eb01d7c15a163be8b8c8151bbb1247259011124a340378dd7dea216aa078";
            string url = $"https://api.mobizon.kz/service/message/sendsmsmessage?recipient={num}&text={message}%21&apiKey={key}";

            


            void AddMessage(int count, string valuta)
            {

            }


            void TakeMessage(int count, string valuta)
            {

            }

            int RandomNumber()
            {
                return
            }

            bool Verification()
            {
                
            }

            using (var webClient = new WebClient())
            {
                // Выполняем запрос по адресу и получаем ответ в виде строки
                var response = webClient.DownloadString(url);
                Console.WriteLine(response);
            }
            Console.ReadLine();
            
        }
    }
}
