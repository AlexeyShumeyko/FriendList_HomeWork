using FriendList_DomainModel.Models;
using FriendList_DomainModel.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendList_Service
{
    public interface IFriendService
    {
        public Task Create(CreateFriendViewModel model);

        public IQueryable<IEntity> GetFriends();
    }
}
