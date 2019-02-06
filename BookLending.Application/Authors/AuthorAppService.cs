using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using AutoMapper;
using BookLending.Models;

namespace BookLending.Authors
{
    public class AuthorAppService:ApplicationService,IAuthorAppService
    {
        private readonly IAuthorManger _authorManger;

        public AuthorAppService(IAuthorManger authorManger)
        {
            _authorManger = authorManger;
        }

        public async Task<IEnumerable<GetAuthorOutput>> GetAll()
        {
            return Mapper.Map<ICollection<GetAuthorOutput>>(await _authorManger.GetAll());
        }

        public async Task<GetAuthorOutput> GetAuthorById(GetAuthorInput getAuthor)
        {
            return Mapper.Map<GetAuthorOutput>(await _authorManger.GetAuthorById(getAuthor.Id));

        }

        public async Task Create(CreateAuthorInput entity)
        {
            var author = Mapper.Map<CreateAuthorInput, Author>(entity);
             await _authorManger.Create(author);
        }

        public async Task Update(UpdateAuthorInput entity)
        {
            var author = Mapper.Map<UpdateAuthorInput, Author>(entity);
           await _authorManger.Update(author);

        }

        public async Task Delete(DeleteAuthorInput deleteAuthor)
        {
            await _authorManger.Delete(deleteAuthor.Id);
        }
    }
}
