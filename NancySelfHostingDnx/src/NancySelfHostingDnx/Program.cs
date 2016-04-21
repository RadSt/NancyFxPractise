using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nancy.Hosting.Self;

namespace NancySelfHostingDnx
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var uri = new Uri("http://localhost:8888/");
            var hostConfig =  new HostConfiguration
            { RewriteLocalhost = true, UrlReservations = new UrlReservations
            { CreateAutomatically = true} };
            var host = new NancyHost(hostConfig, uri);
            try
            {
                Console.WriteLine("Запуск сервера....");
                host.Start();
                Console.WriteLine("Произошел успешно!");
                Console.WriteLine("Для закрытия нажмите любую кнопку...");
            }
            catch (Exception)
            {
                Console.WriteLine("Не удалось запустить. Приложение будет закрыто.");
                return;
            }
            Console.ReadLine();
        }
    }
}
