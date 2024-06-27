using BookApi.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookApi.Services
{
    public interface IBookService
    {
        Task<IEnumerable<BookDto>> GetBooksSortedByPublisherAuthorTitleAsync();
        Task<IEnumerable<BookDto>> GetBooksSortedByAuthorTitleAsync();
        Task<double> GetTotalPriceAsync();
        Task BulkInsertBooksAsync(IEnumerable<BookDto> books);
    }
}
