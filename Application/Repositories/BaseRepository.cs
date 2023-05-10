using Domain.Models.Entity;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Application.Repositories
{
    class BaseRepository<dbEntity> : IBaseRepository<dbEntity> where dbEntity : BaseEntity
    {
        private readonly NgoDbContext context;

        private DbSet<dbEntity> CurrentTable
        {
            get
            {
                return context.Set<dbEntity>();
            }
        }

        public BaseRepository(NgoDbContext context)
        {
            this.context = context;
        }

        public dbEntity Create(dbEntity newItem)
        {
            CurrentTable.Add(newItem);
            return newItem;
        }

        public dbEntity Delete(dbEntity item)
        {
            context.Entry<dbEntity>(item).State = EntityState.Deleted;
            return item;
        }

        public dbEntity Delete(int id)
        {
            dbEntity entity = Read(id);
            context.Entry<dbEntity>(entity).State = EntityState.Deleted;
            return entity;
        }

        public dbEntity Read(int id)
        {
            return CurrentTable.Find(id);
        }

        public IQueryable<dbEntity> Read(Expression<Func<dbEntity, bool>> whereCondition = null,
            Func<IQueryable<dbEntity>, IOrderedQueryable<dbEntity>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<dbEntity> query = CurrentTable;

            if (whereCondition != null)
            {
                query = query.Where(whereCondition);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query);
            }
            else
            {
                return query;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public List<dbEntity> GetAll()
        {
            return CurrentTable.ToList();
        }

        public dbEntity Update(dbEntity item)
        {
            context.Entry<dbEntity>(item).State = EntityState.Modified;
            return item;
        }
    }
}
