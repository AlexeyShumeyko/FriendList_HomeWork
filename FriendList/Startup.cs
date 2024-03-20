using FriendList_DAL;
using FriendList_Service;
using Microsoft.EntityFrameworkCore;

namespace FriendList
{
    public class Startup
    {
        public static void RegisterDAL(WebApplicationBuilder builder)
        {
            var connectionString = builder.Configuration.GetConnectionString("MSSQL");

            builder.Services.AddTransient<DbContextOptions<FriendListDbContext>>(provider =>
            {
                var builder = new DbContextOptionsBuilder<FriendListDbContext>();
                builder.UseSqlServer(connectionString);
                return builder.Options;
            });

            builder.Services.AddScoped<DbContext, FriendListDbContext>();

            //builder.Services.AddSqlServer<DbContext>(connectionString);

            builder.Services.AddScoped<IUnitOfWork>(prov =>
            {
                var context = prov.GetRequiredService<DbContext>();
                return new UnitOfWork(context);
            });
        }

        public static void RegisterService(WebApplicationBuilder builder)
        {
            if (!builder.Environment.IsDevelopment())
                builder.Services.AddScoped<IFriendService, StubFriendService>();

            builder.Services.AddScoped<IFriendService, FriendService>();
        }
    }
}
