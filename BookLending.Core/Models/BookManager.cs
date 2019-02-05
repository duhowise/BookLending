using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;

namespace BookLending.Models
{
    public class BookManager:DomainService,IBookManger
    {
        private readonly IRepository<Book> _bookRepository;

        public BookManager(IRepository<Book> bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public async Task<IEnumerable<Book>> GetAll()
        {
            return await _bookRepository.GetAllListAsync();
        }

        public async Task<Book> GetBookById(int id)
        {
            var book= await _bookRepository.GetAsync(id);
            if (book == null) throw new UserFriendlyException("user ot found");
            return book;
        }

        public async Task<Book> Create(Book entity)
        {
            var book = await _bookRepository.FirstOrDefaultAsync(x => x.Id == entity.Id);
            if (book == null) return await _bookRepository.InsertAsync(entity);
            throw new UserFriendlyException("User already exists");
           
        }

        public async Task Update(Book entity)
        {
            var book = await _bookRepository.FirstOrDefaultAsync(x => x.Id == entity.Id);
            if (book == null) throw new UserFriendlyException("book not found");
            await _bookRepository.UpdateAsync(entity);
        }

        public async Task Delete(int id)
        {
            var book = await _bookRepository.FirstOrDefaultAsync(x => x.Id == id);
            if (book == null) throw new UserFriendlyException("Book not found");
            await _bookRepository.DeleteAsync(book);
        }
    }
}