using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UnityMultiplayerClient
{
    public class SendData
    {

        private string action;
        private string body;
        private byte[] data = new byte[1024];

        public SendData(string action, string body)
        {
            this.action = action;
            this.body = body;
        }

        public string send_data()
        {
            string mehtod = "POST";
            string query = mehtod + " /" + this.action + "\n" + this.body;

            data = Encoding.ASCII.GetBytes(query);
            MultiplayerClient.get_server().SendTo(data, data.Length, SocketFlags.None, MultiplayerClient.get_ipep());

            IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
            EndPoint Remote = (EndPoint)sender;

            data = new byte[1024];
            int recv = MultiplayerClient.get_server().ReceiveFrom(data, ref Remote);

            return Encoding.ASCII.GetString(data, 0, recv);
        }
    }
}