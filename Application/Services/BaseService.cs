using Domain.Models.Entity;
using Domain.Repositories;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    class BaseService<dbEntity> : IBaseService<dbEntity> where dbEntity : BaseEntity
    {
        private readonly IBaseRepository<dbEntity> baseRepository;

        public BaseService(IBaseRepository<dbEntity> baseRepository)
        {
            this.baseRepository = baseRepository;
        }

        public dbEntity Create(dbEntity newItem)
        {
            return baseRepository.Create(newItem);
        }

        public dbEntity Delete(dbEntity item)
        {
            return baseRepository.Delete(item);
        }

        public dbEntity Delete(int id)
        {
            return baseRepository.Delete(id);
        }

        public dbEntity Read(int id)
        {
            return baseRepository.Read(id);
        }

        public IQueryable<dbEntity> Read(Expression<Func<dbEntity, bool>> whereCondition = null, Func<IQueryable<dbEntity>, IOrderedQueryable<dbEntity>> orderBy = null, string includeProperties = "")
        {
            return baseRepository.Read(whereCondition: whereCondition, orderBy: orderBy, includeProperties: includeProperties);
        }

        public void Save()
        {
            baseRepository.Save();
        }

        public dbEntity Update(dbEntity item)
        {
            return baseRepository.Update(item);
        }
    }
}
