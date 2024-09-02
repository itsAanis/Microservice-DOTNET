using Microsoft.EntityFrameworkCore;
using Recreate.Infrastructure.Data.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recreate.Infrastructure.Data.Repositories
{
    public interface IRepository<T>
        where T : EntityBase
    {
        Task<T> GetById(int id);
        Task<T> AddToDb(T entity);

        Task<bool> UpdateDb(T entity, int id );
        Task <bool> DeleteById(int id);
        Task <List<T>> GetAll();
    }
}
