using CatalogoNetflix.WebAPI.Data.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoNetflix.WebAPI.Data.Repositories.Abstractions
{
    public abstract class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly CatalogoContext _context;
        private readonly ILogger<Repository<T>> _logger;

        public Repository(CatalogoContext context, ILogger<Repository<T>> logger)
        {
            _context = context;
            _logger = logger;
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public IList<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public IList<T> Search(Func<T, bool> filter)
        {
            var query = _context.Set<T>();

            return query.Where(filter).ToList();
        }

        public async Task<T> AddOrUpdateAsync(T entity)
        {
            try
            {
                _context.Set<T>().Update(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred at add or update the object in DB.");
            }

            return entity;
        }

        public async Task<IList<T>> AddOrUpdateRangeAsync(IList<T> entity)
        {
            try
            {
                _context.Set<T>().UpdateRange(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred at add or update the objects in DB.");
            }

            return entity;
        }

        public T Remove(T entity)
        {
            try
            {
                _context.Set<T>().Remove(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred at remove the object of DB.");
            }

            return entity;
        }
    }
}
