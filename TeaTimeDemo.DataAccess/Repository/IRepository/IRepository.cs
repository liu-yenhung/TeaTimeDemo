﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TeaTimeDemo.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T: class
    {
        IEnumerable<T> GetAll();
        T Get(Expression<Func<T, bool>>  filter);
        void Add(T entity);
        void Remove(T Entity);
        void RemoveRange(IEnumerable<T> entity);
    }
}
