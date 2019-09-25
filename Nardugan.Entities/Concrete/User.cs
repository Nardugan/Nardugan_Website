using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nardugan.Entities.Concrete
{
    public class User : MongoBaseModel
    {

        [BsonElement("NameSurname")]
        public string NameSurname { get; set; }

        [BsonElement("Email")]
        public string Email { get; set; }

        [BsonElement("Username")]
        public string Username { get; set; }

        [BsonElement("Password")]
        public string Password { get; set; }

        [BsonElement("Photo")]
        public string Photo { get; set; }

        [BsonElement("CreatedDate")]
        public string CreatedDate { get; set; }

        [BsonElement("IsSuperUser")]
        public int IsSuperUser { get; set; }

    }
}
