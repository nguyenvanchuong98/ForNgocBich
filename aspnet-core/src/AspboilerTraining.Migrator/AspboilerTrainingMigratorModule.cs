using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AspboilerTraining.Configuration;
using AspboilerTraining.EntityFrameworkCore;
using AspboilerTraining.Migrator.DependencyInjection;

namespace AspboilerTraining.Migrator
{
    [DependsOn(typeof(AspboilerTrainingEntityFrameworkModule))]
    public class AspboilerTrainingMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public AspboilerTrainingMigratorModule(AspboilerTrainingEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(AspboilerTrainingMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                AspboilerTrainingConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AspboilerTrainingMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
