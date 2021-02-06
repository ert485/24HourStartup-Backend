using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Team5.Configuration;
using Team5.Web;

namespace Team5.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class Team5DbContextFactory : IDesignTimeDbContextFactory<Team5DbContext>
    {
        public Team5DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<Team5DbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            Team5DbContextConfigurer.Configure(builder, configuration.GetConnectionString(Team5Consts.ConnectionStringName));

            return new Team5DbContext(builder.Options);
        }
    }
}
