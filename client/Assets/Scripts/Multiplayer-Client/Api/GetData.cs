using System;
using System.Net;
using System.Net.Sockets;
using System.Text;


namespace UnityMultiplayerClient
{
    public class GetData
    {

        private string action;
        private byte[] data = new byte[1024];

        public GetData(string action)
        {
            this.action = action;
        }

        public string get_data()
        {
            string mehtod = "GET";
            string query = mehtod + " /" + this.action;

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