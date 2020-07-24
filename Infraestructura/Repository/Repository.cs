using Entities;
using Facturacion.Dominio.Repos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Infraestructura.Repository
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {

        public async Task Create (T Entity)
        {
            using (var context = new DataContext())
            {
                await context.Set<T>().AddAsync(Entity);
                await context.SaveChangesAsync();
                    
            }
        }

        public async Task Delete (T Entity)
        {
            using (var context = new DataContext())
            {
                context.Entry(Entity).State = EntityState.Deleted;

                context.Set<T>().Remove(Entity);

                await context.SaveChangesAsync();
            }
        }

        public async Task Update (T Entity)
        {
            using(var context = new DataContext())
            {
                context.Entry(Entity).State = EntityState.Modified;
                context.Set<T>().Update(Entity);
                await context.SaveChangesAsync();
            }

        }

        public async Task<T> GetById (long id, Func<IQueryable<T>,IIncludableQueryable<T, object>> include = null, bool enableTracking = true)
        {
           using (var context = new DataContext())
           {
                IQueryable<T> query = context.Set<T>();

                if (enableTracking)
                {
                    query = query.AsNoTracking();
                }

                if(include != null)
                {
                    query = include(query);
                }


                return await query.FirstOrDefaultAsync(x => x.Id == id);
           }

        }

        public async Task<IEnumerable<T>> GetByFilter(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null, bool enableTracking = true)
        {
            using (var context = new DataContext())
            {
                IQueryable<T> query = context.Set<T>();

                if (enableTracking)
                {
                    query = query.AsNoTracking();
                }

                if (include != null)
                {
                    query = include(query);
                }


                if(predicate != null)
                {
                    query = query.Where(predicate);
                }

                return orderBy != null
                    ? await orderBy(query).ToListAsync()
                    : await query.ToListAsync();

            }
        }

        public async Task<IEnumerable<T>> GetAll(Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null, bool enableTracking = true)
        {
            using (var context = new DataContext())
            {
                IQueryable<T> query = context.Set<T>();

                if (enableTracking)
                {
                    query = query.AsNoTracking();
                }

                if(include != null)
                {
                    query = include(query);
                }

                return orderBy != null ?
                    await orderBy(query).ToListAsync()
                    : await query.ToListAsync();
            }
        }
    }
}
