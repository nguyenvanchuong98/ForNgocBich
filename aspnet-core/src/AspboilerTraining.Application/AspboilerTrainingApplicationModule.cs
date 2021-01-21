using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AspboilerTraining.Authorization;

namespace AspboilerTraining
{
    [DependsOn(
        typeof(AspboilerTrainingCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AspboilerTrainingApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AspboilerTrainingAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AspboilerTrainingApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
