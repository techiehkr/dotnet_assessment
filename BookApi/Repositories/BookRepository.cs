using BookApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


namespace BookApi.Repositories
{
    public class BookRepository : IBookRepository
    {
           private readonly BooksDbContext _context;
    private readonly ILogger<BookRepository> _logger;

        public BookRepository(BooksDbContext context, ILogger<BookRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

        public async Task<IEnumerable<Book>> GetBooksSortedByPublisherAuthorTitleAsync()
        {
            return await _context.Books
                .OrderBy(b => b.Publisher)
                .ThenBy(b => b.AuthorLastName)
                .ThenBy(b => b.AuthorFirstName)
                .ThenBy(b => b.Title)
                .ToListAsync();
        }

        public async Task<IEnumerable<Book>> GetBooksSortedByAuthorTitleAsync()
        {
            return await _context.Books
                .OrderBy(b => b.AuthorLastName)
                .ThenBy(b => b.AuthorFirstName)
                .ThenBy(b => b.Title)
                .ToListAsync();
        }

        public async Task<double> GetTotalPriceAsync()
        {
            return await _context.Books.SumAsync(b => (double)b.Price);
        }

        public async Task BulkInsertBooksAsync(IEnumerable<Book> books)
        {
            await _context.Books.AddRangeAsync(books);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Book>> GetBooksUsingStoredProcedureAsync(string procedureName)
        {
            // Since SQLite does not support EXEC for stored procedures, we'll simulate stored procedures using inline SQL queries.
            if (procedureName == "GetBooksSortedByPublisherAuthorTitle")
            {
                return await GetBooksSortedByPublisherAuthorTitleAsync();
            }
            else if (procedureName == "GetBooksSortedByAuthorTitle")
            {
                return await GetBooksSortedByAuthorTitleAsync();
            }
            else
            {
                throw new ArgumentException($"Stored procedure '{procedureName}' is not defined.");
            }
        }
    }
}
