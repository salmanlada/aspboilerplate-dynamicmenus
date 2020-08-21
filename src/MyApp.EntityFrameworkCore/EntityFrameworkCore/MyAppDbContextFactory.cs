using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MyApp.Configuration;
using MyApp.Web;

namespace MyApp.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MyAppDbContextFactory : IDesignTimeDbContextFactory<MyAppDbContext>
    {
        public MyAppDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MyAppDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MyAppDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MyAppConsts.ConnectionStringName));

            return new MyAppDbContext(builder.Options);
        }
    }
}
