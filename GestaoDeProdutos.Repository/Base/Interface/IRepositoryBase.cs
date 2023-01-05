using System.Linq.Expressions;

namespace GestaoDeProdutos.Repository.Base.Interface;

public interface IRepositoryBase<T>
{
    Task<IQueryable<T>> FindAllAsync();
    Task<IQueryable<T>> FindByConditionAsync(Expression<Func<T, bool>> expression);
    Task CreateAsync(T entity);
    Task UpdateAsync(T entity);
    Task RemoveAsync(T entity);
}