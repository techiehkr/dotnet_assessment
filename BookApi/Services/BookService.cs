
using AutoMapper;
using BookApi.Dtos;
using BookApi.Models;
using Microsoft.Extensions.Logging;
namespace BookApi.Services
{
    public class BookService : IBookService
    {
    private readonly IBookRepository _bookRepository;
    private readonly IMapper _mapper;
    private readonly ILogger<BookService> _logger;

        public BookService(IBookRepository bookRepository, IMapper mapper,ILogger<BookService> logger)
        {
        _bookRepository = bookRepository;
        _mapper = mapper;
        _logger = logger;
        }

        public async Task<IEnumerable<BookDto>> GetBooksSortedByPublisherAuthorTitleAsync()
        {
            var books = await _bookRepository.GetBooksSortedByPublisherAuthorTitleAsync();
            return _mapper.Map<IEnumerable<BookDto>>(books);
        }

        public async Task<IEnumerable<BookDto>> GetBooksSortedByAuthorTitleAsync()
        {
            var books = await _bookRepository.GetBooksSortedByAuthorTitleAsync();
            return _mapper.Map<IEnumerable<BookDto>>(books);
        }

        public async Task<double> GetTotalPriceAsync()
        {
            return await _bookRepository.GetTotalPriceAsync();
        }

        public async Task BulkInsertBooksAsync(IEnumerable<BookDto> books)
        {
            var bookEntities = _mapper.Map<IEnumerable<Book>>(books);
            await _bookRepository.BulkInsertBooksAsync(bookEntities);
        }
    }
}
