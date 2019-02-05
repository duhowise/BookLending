using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BookLending.Roles.Dto;
using BookLending.Users.Dto;

namespace BookLending.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}