using System.Collections.Generic;
using System.Linq;
using Altaliza.Core.Entities;
using Altaliza.Core.Repositories;
using Altaliza.DAL.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Altaliza.DAL.Repositories.MySQL
{
    public class BaseEntityRepository<TBase> : IBaseEntityRepository<TBase> where TBase : BaseEntity
    {
        protected readonly MySQLContext context;
        protected DbSet<TBase> dbSet;

        public BaseEntityRepository(MySQLContext appDbContext)
        {
            context = appDbContext;
            dbSet = context.Set<TBase>();
        }

        public TBase GetOne(int id)
        {
            return dbSet.Where(e => e.Id == id).SingleOrDefault();
        }

        public IEnumerable<TBase> GetAll()
        {
            return dbSet.ToList<TBase>();
        }

        public void Create(TBase tBase)
        {
            dbSet.Add(tBase);
        }

        public void Update(TBase tBase)
        {
            context.Entry(tBase).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            TBase entity = GetOne(id);
            context.Entry(entity).State = EntityState.Deleted;
        }

        public int Commit()
        {
            return context.SaveChanges();
        }

    }
}