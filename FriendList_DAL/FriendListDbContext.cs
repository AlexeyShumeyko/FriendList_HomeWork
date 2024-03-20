using FriendList_DomainModel.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendList_DAL
{
    public class FriendListDbContext : DbContext
    {
        public FriendListDbContext(DbContextOptions<FriendListDbContext> options) : base(options)
        {
        }

        public DbSet<Friend> Friends { get; set; }
    }
}
