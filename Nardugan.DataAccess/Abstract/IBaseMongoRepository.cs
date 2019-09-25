using Nardugan.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nardugan.DataAccess.Abstract
{
    public interface IBaseMongoRepository<T> where T : MongoBaseModel
    {
        List<T> GetAll();
        T GetById(string id);
        void AddModel(T model);
        void UpdateModel(string id, T model);
        void DeleteModel(string id);
    }
}
