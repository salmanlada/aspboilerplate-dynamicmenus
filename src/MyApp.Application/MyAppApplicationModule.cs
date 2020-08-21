using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyApp.Authorization;

namespace MyApp
{
    [DependsOn(
        typeof(MyAppCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MyAppApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MyAppAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MyAppApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
