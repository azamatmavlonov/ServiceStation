using System;
using System.Collections.Generic;
using System.Text;
using ServiceStation.Base;

namespace ServiceStation.DataProvider
{
    public interface IDataProvider<T> where T: EntityBase
    {
        public void Add(T entity);
        public void Delete(T entity);
        T GetById(long id);
        public void Update(T customer);
    }
}
