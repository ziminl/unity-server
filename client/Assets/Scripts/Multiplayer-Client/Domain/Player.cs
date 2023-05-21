using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UnityMultiplayerClient
{
    public class Player : MonoBehaviour
    {

        public string username;
        public string password;
        private string token;
        PlayerAuth player_auth = new PlayerAuth();

        void Start()
        {
            this.token = player_auth.login(this.username, this.password);
            Debug.Log(this.token);
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
            Debug.Log(player_auth.get_my_name());
            }
        }

    }
}

