using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Team5.EntityFrameworkCore
{
    public static class Team5DbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<Team5DbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<Team5DbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
