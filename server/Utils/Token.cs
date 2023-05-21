using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityServer
{
    internal class GenerateTokenSession
    {

        private string token;
        private byte[] expire_time;
        private byte[] key;

        public GenerateTokenSession() 
        {
            this.expire_time = BitConverter.GetBytes(DateTime.UtcNow.ToBinary());
            this.key = Guid.NewGuid().ToByteArray();
            this.token = Convert.ToBase64String(expire_time.Concat(key).ToArray());
        }

        public string GetToken()
        {
            return this.token;
        }

        static public bool CheckTokenExpire(string token_to_check)
        {
            byte[] data = Convert.FromBase64String(token_to_check);
            DateTime when = DateTime.FromBinary(BitConverter.ToInt64(data, 0));

            // the maximum time of a session is 24 hours
            if (when < DateTime.UtcNow.AddHours(-24))
            {
                return false;
            }

            return true;

        }
    }
}
