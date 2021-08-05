using System;

namespace SerializacaoXML.Entities
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public override string ToString()
        {
            return $"Name: {Username}\n" +
                   $"Email: {Email}\n" +
                   $"BirthDate: {BirthDate}";
        }
    }
}