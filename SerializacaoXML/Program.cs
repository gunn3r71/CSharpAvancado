using System;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;
using SerializacaoXML.Entities;

namespace SerializacaoXML
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

            var xmlSerializer = new XmlSerializer(typeof(User));

            using (var writer = new StreamWriter(@"C:\Users\lucas\Downloads\XmlSave\xmlTeste.xml"))
            {
                xmlSerializer.Serialize(writer, user);
            }
        }
    }
}
