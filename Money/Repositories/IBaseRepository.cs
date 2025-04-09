namespace Money.Repositories;

public interface IBaseRepository<T> where T:class
{
    Task<bool> Create(T entity);
    Task<bool> Update(T Entity);
    Task<bool> Delete(T entity);
    Task<IEnumerable<T>> GetAll();

    Task<bool> Save();
}
