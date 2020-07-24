using Entities;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Dominio.Repos
{
    public interface IRepository<T> where T : EntityBase
    {
         Task Create(T Entity);
   

        Task Delete(T Entity);
        

         Task Update(T Entity);

        //Get By Id
        Task<T> GetById(long id, Func<IQueryable<T>, IIncludableQueryable<T,
        object>> include = null, 
        bool enableTracking = true);

        //Get By Filter 
        Task<IEnumerable<T>> GetByFilter(Expression<Func<T, bool>> predicate = null,
        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
        Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
        bool enableTracking = true);


        //Get All
        Task<IEnumerable<T>> GetAll(Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
        Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
        bool enableTracking = true);
    }
}
