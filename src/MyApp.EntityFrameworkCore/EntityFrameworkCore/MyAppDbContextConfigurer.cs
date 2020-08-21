using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MyApp.EntityFrameworkCore
{
    public static class MyAppDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MyAppDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MyAppDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
