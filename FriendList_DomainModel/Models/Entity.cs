using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendList_DomainModel.Models
{
    public class Entity<TIdentifier> : IEntity
    {
        public TIdentifier? Id { get; set; }
    }
}
