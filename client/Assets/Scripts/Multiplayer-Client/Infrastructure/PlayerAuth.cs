using System.Collections;
using System.Collections.Generic;
using System;

namespace UnityMultiplayerClient
{
    public class PlayerAuth
    {

        public PlayerAuth() {}

        public string login(string username, string password)
        {
            /*
            POST /login
            username: your_username
            password: your_password
            */

            string body = "username:" + username + "\n" + "password:" + password;
            SendData new_send_data = new SendData("login", body);

            return new_send_data.send_data();
        }

        public string get_my_name()
        {

            GetData my_name = new GetData("get_my_name");
            return my_name.get_data();
        }

    }
}