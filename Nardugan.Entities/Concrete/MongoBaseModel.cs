using MongoDB.Bson;
using Nardugan.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nardugan.Entities.Concrete
{
    public class MongoBaseModel : IEntity
    {

        public ObjectId Id { get; set; }

    }
}
