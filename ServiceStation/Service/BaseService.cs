using System;
using System.Collections.Generic;
using System.Text;
using ServiceStation.Base;
using ServiceStation.DataProvider;

namespace ServiceStation.Service
{
    public abstract class BaseService<T> : IBaseService<T> where T: EntityBase
    {
        private readonly IDataProvider<T> _dataProvider;
        public BaseService(IDataProvider<T> dataProvider) 
        {
            _dataProvider = dataProvider;
        }

        public void Add(T entity)
        {
            _dataProvider.Add(entity);
        }

        public void Delete(T entity)
        {
            throw new System.NotImplementedException();
        }

        public T GetById(long id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(T customer)
        {
            throw new System.NotImplementedException();
        }
    }
}
