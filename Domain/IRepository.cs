using MPPIS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPPIS.Domain
{
    public interface IRepository<TEntity> where TEntity : IEntityBase
    {

        /// <summary>
        /// Enables further filtering by returning IQueryable
        /// </summary>
        /// <returns>entity framework's entity</returns>
        IQueryable<TEntity> GetAll();
    }
}
