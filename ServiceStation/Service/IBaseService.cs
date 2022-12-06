using System;
using System.Collections.Generic;
using System.Text;
using ServiceStation.Base;

namespace ServiceStation.Service
{
    public interface IBaseService<T> where T: EntityBase
    {
        void Add(T entity);
        void Delete(T entity);
        T GetById(long id);
        void Update(T entity);
    }
}
