using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AspboilerTraining.EntityFrameworkCore;
using AspboilerTraining.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace AspboilerTraining.Web.Tests
{
    [DependsOn(
        typeof(AspboilerTrainingWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class AspboilerTrainingWebTestModule : AbpModule
    {
        public AspboilerTrainingWebTestModule(AspboilerTrainingEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AspboilerTrainingWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(AspboilerTrainingWebMvcModule).Assembly);
        }
    }
}