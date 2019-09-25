using Nardugan.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nardugan.DataAccess.Concrete
{
    public class MessageRepository : BaseMongoRepository<Message>
    {

        public MessageRepository(string mongoDbConnectionString, string dbName, string collectionName) : base(mongoDbConnectionString, dbName, collectionName)
        {
                
        }

    }
}
