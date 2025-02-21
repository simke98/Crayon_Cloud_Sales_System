using Crayon.CSS.Application.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Crayon.CSS.Persistence.Repositories;

public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
{
    protected CSSDBContext DbContext { get; set; }

    public RepositoryBase(CSSDBContext dbContext)
    {
        DbContext = dbContext;
    }

    public IQueryable<T> FindAll()
    {
        return DbContext.Set<T>().AsNoTracking();
    }

    public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
    {
        return DbContext.Set<T>().Where(expression).AsNoTracking();
    }

    public async Task<T> Create(T entity)
    {
        var result = await DbContext.Set<T>().AddAsync(entity);
        await DbContext.SaveChangesAsync();
        return result.Entity;
    }

    public async Task Update(T entity)
    {
        DbContext.Set<T>().Update(entity);
        await DbContext.SaveChangesAsync();
    }

    public void Delete(T entity)
    {
        DbContext.Set<T>().Remove(entity);
    }
}
