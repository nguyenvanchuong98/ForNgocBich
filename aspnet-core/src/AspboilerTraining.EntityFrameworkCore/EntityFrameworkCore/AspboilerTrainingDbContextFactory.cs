using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using AspboilerTraining.Configuration;
using AspboilerTraining.Web;

namespace AspboilerTraining.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AspboilerTrainingDbContextFactory : IDesignTimeDbContextFactory<AspboilerTrainingDbContext>
    {
        public AspboilerTrainingDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AspboilerTrainingDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AspboilerTrainingDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AspboilerTrainingConsts.ConnectionStringName));

            return new AspboilerTrainingDbContext(builder.Options);
        }
    }
}
