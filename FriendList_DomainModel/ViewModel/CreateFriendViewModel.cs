using FriendList_DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendList_DomainModel.ViewModel
{
    public class CreateFriendViewModel : Entity<int>
    {
        public string Name { get; set; }

        public string Place { get; set; }
    }
}
