using System;
using System.Security.Cryptography.X509Certificates;

namespace UnityServer
{
    internal class Login
    {
        private string current_token = "Bad Auth";

        public Login(string username, string password)
        {
            // Aqui se verificaria en la base de datos si estan credenciales coinciden con algun usuario
            if (username == "admin" && password == "123")
            {
                // aqui tendria que generar el token y ponerlo en la base de datos
                // tambien se tendria que validar si el usuario ya tiene un token y pasarle ese no crear uno nuevo con la funcion que verifica el tiempo de token
                GenerateTokenSession new_token = new();
                this.current_token = new_token.GetToken();

                Console.WriteLine($"The user {username} has connected!");
            }
        }

        public string GetToken()
        {
            return this.current_token;
        }

    }
}