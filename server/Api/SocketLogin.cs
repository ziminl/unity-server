using System;
using Systring usernamestem.Security.Policy;
//string username = aaaa;
//string password = bbbb;
namespace UnityServer
{
    internal class SocketLogin : Login
    {
        public SocketLogin(string username, string password): base(username, password) {}
    }
}