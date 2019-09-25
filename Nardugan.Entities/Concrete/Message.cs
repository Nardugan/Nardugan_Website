using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nardugan.Entities.Concrete
{
    public class Message : MongoBaseModel
    {

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("Number")]
        public string Number { get; set; }

        [BsonElement("Mail")]
        public string Mail { get; set; }

        [BsonElement("Title")]
        public string Title { get; set; }

        [BsonElement("Content")]
        public string Content { get; set; }

        [BsonElement("Date")]
        public string Date { get; set; }

    }
}
