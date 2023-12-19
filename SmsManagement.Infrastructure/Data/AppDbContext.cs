

using SmsManagement.SheredKernel.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading;
using System.Threading.Tasks;

namespace SmsManagement.Infrastructure.Data
{
    public class AppDbContext<T> : DbContext, IAppDbContext<T> where T : class
    {
        public AppDbContext():base("name=AppDbConnection")
        {
        }
        public DbSet<T> Entity { get; set ; }

        public virtual async Task<T> AddAsync(T entity, CancellationToken cancellationToken = default)
        {
            Set<T>().Add(entity);

            await SaveChangesAsync(cancellationToken);

            return entity;
        }
        public virtual async Task DeleteAsync(T entity, CancellationToken cancellationToken = default)
        {
            Set<T>().Remove(entity);

            await SaveChangesAsync(cancellationToken);
        }
        public virtual async Task DeleteRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
        {
            Set<T>().RemoveRange(entities);

            await SaveChangesAsync(cancellationToken);
        }
        //-------------------------read--------------------------------------------------
        public virtual async Task<List<T>> ListAsync(CancellationToken cancellationToken = default)
        {
            return await Set<T>().ToListAsync(cancellationToken);
        }
        public virtual async Task<int> CountAsync(CancellationToken cancellationToken = default)
        {
            return await Set<T>().CountAsync(cancellationToken);
        }
        public virtual async Task<bool> AnyAsync(CancellationToken cancellationToken = default)
        {
            return await Set<T>().AnyAsync(cancellationToken);
        }
    }
}
