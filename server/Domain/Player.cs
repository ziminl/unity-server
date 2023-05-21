using System;
using System.Security.Policy;

namespace UnityServer
{
    internal class Player  
    {
        public string username;

        public Player(string username)
        {
            this.username = username;
        }

        public string GetMyName()
        {
            return this.username;
        }
    }
}