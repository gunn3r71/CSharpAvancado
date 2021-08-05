using System;
using System.IO;
using Newtonsoft.Json;
using SerializacaoXML.Entities;

namespace DeserialzacaoJson
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();

            var json = new JsonSerializer();

            using (var jsonSerializer = new JsonTextReader(new StreamReader(@"C:\Users\lucas\Downloads\JsonSave\teste.json")))
            {
                user = json.Deserialize<User>(jsonSerializer);
            }

            Console.WriteLine(user);
        }
    }
}
