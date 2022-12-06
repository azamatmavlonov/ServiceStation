using System;
using System.Collections.Generic;
using System.Text;
using ServiceStation.Base;

namespace ServiceStation.DataProvider
{
    public class FileDataProvider<T>: IDataProvider<T> where T: EntityBase
    {
        public void Add(T entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new System.NotImplementedException();
        }

        public T GetById(long Id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
