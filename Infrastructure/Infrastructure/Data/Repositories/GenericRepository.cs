using Microsoft.EntityFrameworkCore;
using Recreate.Infrastructure.Data.Abstractions;
using Recreate.Infrastructure.Data.Entities;
using Recreate.Infrastructure.Data.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recreate.Infrastructure.Data.Repositories
{
    public  class GenericRepository<T> : IRepository<T>
        where T : EntityBase
    {

        protected RecreateDbContext _dbContext;
        public GenericRepository(RecreateDbContext dbContext) {

            _dbContext = dbContext;
        }

        public async Task<T> AddToDb(T entity)
        {
            var something = await _dbContext.Set<T>().AddAsync(entity);
                      int what = await _dbContext.SaveChangesAsync();
            T entity2 = await _dbContext.Set<T>().FindAsync(entity.Id);
            return entity2;
        }

        public async Task<bool> DeleteById(int id)
        {
            T entity = await _dbContext.Set<T>().FindAsync(id);
            if (entity != null)
            {
                _dbContext.Set<T>().Remove(entity);
                await _dbContext.SaveChangesAsync();
                return true;
            }

            return false;

        }

        public async Task<T> GetById(int id)
        {
            T entity = await _dbContext.Set<T>().FindAsync(id);

            return entity;
        }

        public async Task< List<T>> GetAll () {
            List<T> EntityBase = await _dbContext.Set<T>().ToListAsync();
            return EntityBase;
        }

        public  async Task<bool> UpdateDb(T entity, int id)
        {
            
          var exist  = await _dbContext.Set<T>().FindAsync(id);// id

                    _dbContext.Entry(exist).CurrentValues.SetValues(entity);
                    await _dbContext.SaveChangesAsync();
            return true;
        }

      
    }
}
