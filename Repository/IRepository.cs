using Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepository<T> where T : EntityBase
    {
        public Task Create(T Entity);

        public Task Delete(T Entity);

        public Task Update(T Entity);


        public Task<T> GetById (long id, Func<IQueryable, IIncludableQueryable<T, object>> include = null, bool enableTracking = true)
    }
}
