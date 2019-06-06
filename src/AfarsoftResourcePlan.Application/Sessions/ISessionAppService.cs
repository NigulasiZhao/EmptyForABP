using System.Threading.Tasks;
using Abp.Application.Services;
using AfarsoftResourcePlan.Sessions.Dto;

namespace AfarsoftResourcePlan.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
