﻿using System.Linq.Expressions;

namespace Crayon.CSS.Application.Repositories;

public interface IRepositoryBase<T>
{
    IQueryable<T> FindAll();
    IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
    Task<T> Create(T entity);
    Task Update(T entity);
    void Delete(T entity);
}
