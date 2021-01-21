using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AspboilerTraining.EntityFrameworkCore
{
    public static class AspboilerTrainingDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AspboilerTrainingDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AspboilerTrainingDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
