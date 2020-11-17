using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CatalogoNetflix.WebAPI.Data.Repositories.Abstractions
{
    public interface IRepository<T> where T : class
    {
        T GetById(int id);
        IList<T> GetAll();
        IList<T> Search(Func<T, bool> filter);
        Task<T> AddOrUpdateAsync(T entity);
        Task<IList<T>> AddOrUpdateRangeAsync(IList<T> list);
        T Remove(T entity);
    }
}
