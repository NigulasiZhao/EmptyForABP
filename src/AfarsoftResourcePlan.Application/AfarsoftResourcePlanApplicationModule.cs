using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AfarsoftResourcePlan.Authorization;

namespace AfarsoftResourcePlan
{
    [DependsOn(
        typeof(AfarsoftResourcePlanCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AfarsoftResourcePlanApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AfarsoftResourcePlanAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AfarsoftResourcePlanApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
