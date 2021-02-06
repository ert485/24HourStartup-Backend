using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Team5.Authorization;

namespace Team5
{
    [DependsOn(
        typeof(Team5CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class Team5ApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<Team5AuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(Team5ApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
