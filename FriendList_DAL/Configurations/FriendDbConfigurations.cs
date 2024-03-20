using FriendList_DomainModel.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendList_DAL.Configurations
{
    internal class FriendDbConfigurations : IEntityTypeConfiguration<Friend>
    {
        public void Configure(EntityTypeBuilder<Friend> builder)
        {
        }
    }
}
