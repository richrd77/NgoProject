using Domain.Models.Entity;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Domain.Repositories
{
    public interface IBaseRepository<dbEntity> where dbEntity : BaseEntity
    {
        /// <summary>
        /// Inserts new row in the table
        /// </summary>
        /// <param name="newItem"></param>
        /// <returns></returns>
        dbEntity Create(dbEntity newItem);

        /// <summary>
        /// get data by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        dbEntity Read(int id);

        /// <summary>
        /// get data by where condition
        /// </summary>
        /// <param name="whereCondition">(optional) Where Condition</param>
        /// <param name="orderBy">(optional) order by</param>
        /// <param name="includeProperties">(optional) property names seperated by ,</param>
        /// <returns></returns>
        IQueryable<dbEntity> Read(Expression<Func<dbEntity, bool>> whereCondition = null,
        Func<IQueryable<dbEntity>, IOrderedQueryable<dbEntity>> orderBy = null,
        string includeProperties = "");

        /// <summary>
        /// Updates the row in the Db
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        dbEntity Update(dbEntity item);

        /// <summary>
        /// Deletes the row in the table
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        dbEntity Delete(dbEntity item);

        /// <summary>
        /// Deletes the row in the table
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        dbEntity Delete(int id);

        /// <summary>
        /// Saves the changes to DB
        /// </summary>
        void Save();
    }
}
