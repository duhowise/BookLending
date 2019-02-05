using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;

namespace BookLending.Models
{
    public class AuthorManager:DomainService,IAuthorManger
    {
        private readonly IRepository<Author> _authorRepository;

        public AuthorManager(IRepository<Author> authorRepository)
        {
            _authorRepository = authorRepository;
        }
        public async Task<IEnumerable<Author>> GetAll()
        {
         return await  Task.FromResult(_authorRepository.GetAllIncluding(x => x.Books).ToList());
        }

        public async Task<Author> GetAuthorById(int id)
        {
            var author= await _authorRepository.GetAsync(id);
            if (author == null) throw new UserFriendlyException("user ot found");
            return author;
        }

        public async Task<Author> Create(Author entity)
        {
            var author = await _authorRepository.FirstOrDefaultAsync(x => x.Id == entity.Id);
            if (author == null) return await _authorRepository.InsertAsync(entity);
            throw new UserFriendlyException("User already exists");
           
        }

        public async Task Update(Author entity)
        {
           await _authorRepository.UpdateAsync(entity);
        }

        public async Task Delete(int id)
        {
            var author = await _authorRepository.FirstOrDefaultAsync(x => x.Id == id);
             await _authorRepository.DeleteAsync(author);
            throw new UserFriendlyException("author not found");
        }
    }
}
