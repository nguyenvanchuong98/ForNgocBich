using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AspboilerTraining.Configuration;

namespace AspboilerTraining.Web.Host.Startup
{
    [DependsOn(
       typeof(AspboilerTrainingWebCoreModule))]
    public class AspboilerTrainingWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AspboilerTrainingWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AspboilerTrainingWebHostModule).GetAssembly());
        }
    }
}
