using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using AutoMapper;
using BookLending.Models;

namespace BookLending.Books
{
    public class BookAppService:ApplicationService,IBookAppService
    {
        private readonly IBookManger _bookManger;

        public BookAppService(IBookManger bookManger)
        {
            _bookManger = bookManger;
        }
        public async Task<IEnumerable<GetBookOutput>> GetAll()
        {
            return Mapper.Map<ICollection<GetBookOutput>>(await _bookManger.GetAll());
        }

        public async Task<GetBookOutput> GetBookById(GetBookInput getBook)
        {
            return Mapper.Map<GetBookOutput>(await _bookManger.GetBookById(getBook.Id));

        }

        public async Task Create(CreateBookInput entity)
        {
            var book = Mapper.Map<CreateBookInput, Book>(entity);
            await _bookManger.Create(book);
        }

        public async Task Update(UpdateBookInput entity)
        {
            var book = Mapper.Map<UpdateBookInput, Book>(entity);
            await _bookManger.Update(book);
        }

        public async Task Delete(DeleteBookInput deleteBook)
        {
            await _bookManger.Delete(deleteBook.Id);
        }
    }
}
