using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UnityMultiplayerClient
{
    public class MultiplayerClient : MonoBehaviour
    {

        static IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5000);
        static Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

        static public Socket get_server()
        {
            return server;
        }

        static public IPEndPoint get_ipep()
        {
            return ipep;
        }
        
    }
}


