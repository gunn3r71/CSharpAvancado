using System;
using System.Xml.Serialization;
using SerializacaoXML.Entities;

namespace DeserializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();

            var xmlSerialize = new XmlSerializer(typeof(User));

            
        }
    }
}
