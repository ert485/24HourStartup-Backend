using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Team5.EntityFrameworkCore;
using Team5.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Team5.Web.Tests
{
    [DependsOn(
        typeof(Team5WebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class Team5WebTestModule : AbpModule
    {
        public Team5WebTestModule(Team5EntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Team5WebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(Team5WebMvcModule).Assembly);
        }
    }
}