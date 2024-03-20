using FriendList_DomainModel.Models;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendList_DAL
{
    public interface IUnitOfWork
    {
        IDbContextTransaction BeginTransaction();

        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class, IEntity;

        Task<int> SaveChangesAsync();
    }
}
