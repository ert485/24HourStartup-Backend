using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Team5.Authorization.Roles;
using Team5.Authorization.Users;
using Team5.MultiTenancy;

namespace Team5.EntityFrameworkCore
{
    public class Team5DbContext : AbpZeroDbContext<Tenant, Role, User, Team5DbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public Team5DbContext(DbContextOptions<Team5DbContext> options)
            : base(options)
        {
        }
    }
}
