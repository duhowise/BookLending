using System.Threading.Tasks;
using Abp.Application.Services;
using BookLending.Sessions.Dto;

namespace BookLending.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
