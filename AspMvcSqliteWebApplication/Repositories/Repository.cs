using AspMvcSqliteWebApplication.DatabaseContexts;
using AspMvcSqliteWebApplication.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AspMvcSqliteWebApplication.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly CompanyContext context;
        private readonly DbSet<T> dbSet;

        public Repository(CompanyContext context)
        {
            this.context = context;
            dbSet = context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }

        public T? GetById(int id)
        {
            return dbSet.Find(id);
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            this.context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            T? entity = dbSet.Find(id);
            if (entity != null)
            {
                dbSet.Remove(entity);
            }
        }
    }
}