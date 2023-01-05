using Microsoft.EntityFrameworkCore;
using GestaoDeProdutos.Repository.Data;
using GestaoDeProdutos.Repository.Base.Interface;
using System.Linq.Expressions;

namespace GestaoDeProdutos.Repository.Base.Repository;

public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
{
    protected RepositoryContext RepositoryContext;
    public RepositoryBase(RepositoryContext repositoryContext) =>
        RepositoryContext = repositoryContext;

    public async Task<IQueryable<T>> FindAllAsync() => await Task.Run(() => RepositoryContext.Set<T>());

    public async Task<IQueryable<T>> FindByConditionAsync(Expression<Func<T, bool>> expression) => await Task.Run(() => RepositoryContext.Set<T>().Where(expression));

    public async Task CreateAsync(T entity) => await Task.Run(() => RepositoryContext.Set<T>().Add(entity));

    public async Task UpdateAsync(T entity) => await Task.Run(() => RepositoryContext.Set<T>().Update(entity));

    public async Task RemoveAsync(T entity) => await Task.Run(() => RepositoryContext.Set<T>().Remove(entity));
}