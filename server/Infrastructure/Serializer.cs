using System;


namespace UnityServer
{
    internal class Serializer
    {
        static public string GetMethod(string query)
        {
            string[] words = query.Split(" ");

            if (words[0] == "POST")
            {
                return words[0];
            }
            else if (words[0] == "GET")
            {
                return "GET";
            }
                
            return "ERROR";
        }

        static public string GetAction(string query)
        {
            string[] words = query.Split("\n");
            string[] result = words[0].Split(" ");

            return result[1];
        }

        static public IDictionary<string, string> GetBody(string query)
        {
            string[] words = query.Split("\n");
            words = words[1..];

            IDictionary<string, string> result = new Dictionary<string, string>();

            foreach (var word in words)
            {
                string[] current = word.Split(':');
                result.Add(current[0], current[1]);
            }

            return result;
        }
    }
}