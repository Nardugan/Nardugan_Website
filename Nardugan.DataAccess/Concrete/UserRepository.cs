using Nardugan.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nardugan.DataAccess.Concrete
{
    public class UserRepository : BaseMongoRepository<User>
    {

        public UserRepository(string mongoDbConnectionString, string dbName, string collectionName) : base(mongoDbConnectionString, dbName, collectionName)
        {

        }

    }
}
