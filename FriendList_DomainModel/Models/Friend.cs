using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendList_DomainModel.Models
{
    public class Friend : Entity<int>
    {
        public required string Name { get; set; }

        public required string Place { get; set; }
    }
}
