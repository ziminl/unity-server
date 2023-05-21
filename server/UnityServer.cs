using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Configuration;

namespace UnityServer
{
    internal class Server
    {
        
        public static int PORT = Int32.Parse(ConfigurationManager.AppSettings.Get("PORT") ?? "5000");

        static void Main()
        {

            byte[] data;
            IPEndPoint ipep = new(IPAddress.Any, PORT);
            UdpClient newsock = new(ipep);
            Console.WriteLine("Running Server on port "+ PORT+ ", waiting for clients..");
            IPEndPoint sender = new(IPAddress.Any, 0);

            while (true)
            {
                data = newsock.Receive(ref sender);
                string current_petition = Encoding.ASCII.GetString(data, 0, data.Length);

                if (Serializer.GetMethod(current_petition) == "POST" && Serializer.GetAction(current_petition) == "/login")
                {
                    IDictionary<string, string> credentials =  Serializer.GetBody(current_petition);

                    // this will be generate a Token ID
                    SocketLogin new_login = new(credentials["username"], credentials["password"]);
                    data = Encoding.ASCII.GetBytes(new_login.GetToken());
                    newsock.Send(data, data.Length, sender);

                }
            }

        }
    }
}