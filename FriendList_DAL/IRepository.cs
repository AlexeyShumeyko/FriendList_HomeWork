using FriendList_DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendList_DAL
{
    public interface IRepository<TEntity> where TEntity : class, IEntity
    {
        TEntity Create(TEntity entity);

        TEntity Delete(TEntity entity);

        IQueryable<TEntity> AsQueryable();
    }
}
