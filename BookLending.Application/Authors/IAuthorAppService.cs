using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Abp.Application.Services;
using BookLending.Models;

namespace BookLending.Authors
{
    public interface IAuthorAppService:IApplicationService
    {
        Task<IEnumerable<GetAuthorOutput>> GetAll();
        Task<GetAuthorOutput> GetAuthorById(GetAuthorInput id);
        Task Create(CreateAuthorInput entity);
        Task Update(UpdateAuthorInput entity);
        Task Delete(DeleteAuthorInput id);
    }
}
