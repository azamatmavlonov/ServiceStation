using System;
using System.Collections.Generic;
using System.Text;
using ServiceStation.Base;

namespace ServiceStation.DataProvider
{
    public class JsonDataProvider<T> : IDataProvider<T> where T : EntityBase
    {
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T GetById(long id)
        {
            throw new NotImplementedException();
        }

        public void Update(T customer)
        {
            throw new NotImplementedException();
        }
    }
}
