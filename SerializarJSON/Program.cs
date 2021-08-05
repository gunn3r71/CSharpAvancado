using System;
using System.IO;
using Newtonsoft.Json;
using SerializacaoXML.Entities;

namespace SerializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User
            {
                Username = "Lucas",
                Email = "lucas.p.oliveira@outlook.pt",
                BirthDate = new DateTime(2002, 07, 30)
            };

            var json = new JsonSerializer();
            
            using (var jsonSerializer = new JsonTextWriter(new StreamWriter(@"C:\Users\lucas\Downloads\JsonSave\teste.json")))
            {
                json.Serialize(jsonSerializer, user);
            }
        }
    }
}
