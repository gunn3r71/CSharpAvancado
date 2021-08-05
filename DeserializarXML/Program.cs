using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using SerializacaoXML.Entities;

namespace DeserializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmlSerialize = new XmlSerializer(typeof(User));
            var user = new User();
            using (var reader = new StreamReader(@"C:\Users\lucas\Downloads\XmlSave\xmlTeste.xml"))
            {
                user = (User) xmlSerialize.Deserialize(reader);
            }

            Console.WriteLine(user);
        }
    }
}
