﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDapper.Repository
{
    public interface IgenericRepository<T> where T : class
    {
        T GetById(int id);

        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
    }
}
