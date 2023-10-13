using AspMvcSqliteWebApplication.DatabaseContexts;
using AspMvcSqliteWebApplication.Entities;
using AspMvcSqliteWebApplication.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AspMvcSqliteWebApplication.Repositories
{
    public class Repository<T> : IRepository<T> where T : TableData
    {
        private readonly CompanyContext context;
        private readonly DbSet<T> dbSet;

        public Repository(CompanyContext context)
        {
            this.context = context;
            dbSet = context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await dbSet.ToListAsync();
        }

        public async Task<T?> GetById(Guid id)
        {
            return await dbSet.FindAsync(id);
        }

        public async Task Add(T entity)
        {
            await dbSet.AddAsync(entity);
        }

        public async Task Update(T entity)
        {
            T? entityData = await dbSet.FindAsync(entity.Id);
            if (entityData != null)
            {
                dbSet.Remove(entityData);
                await dbSet.AddAsync(entity);
            }
        }

        public async Task Delete(Guid id)
        {
            T? entity = await dbSet.FindAsync(id);
            if (entity != null)
            {
                dbSet.Remove(entity);
            }
        }

        public async Task<int> SaveChanges()
        {
            return await context.SaveChangesAsync();
        }
    }
}