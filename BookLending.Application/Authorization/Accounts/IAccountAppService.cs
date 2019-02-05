using System.Threading.Tasks;
using Abp.Application.Services;
using BookLending.Authorization.Accounts.Dto;

namespace BookLending.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
