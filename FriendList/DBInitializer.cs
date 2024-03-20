using System.Data.Common;
using FriendList.Exceptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace FriendList
{
    internal class DBInitializer
    {
        public static void InitializeDB(IServiceProvider serviceProvider)
        {
            if (!ApplyMigrations(serviceProvider))
            {
                throw new DbInitializationException("Could not initialize DB! See errors above.");
            }
        }

        private static bool ApplyMigrations(IServiceProvider serviceProvider)
        {
            var scope = serviceProvider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<DbContext>();

            try
            {
                context.Database.Migrate();
            }
            catch
            {
                return false;
            }
            return true;

        }
    }
}
