using BookApi.Models;

public interface IBookRepository
{
    Task<IEnumerable<Book>> GetBooksSortedByPublisherAuthorTitleAsync();
    Task<IEnumerable<Book>> GetBooksSortedByAuthorTitleAsync();
    Task<double> GetTotalPriceAsync();
    Task BulkInsertBooksAsync(IEnumerable<Book> books);
    Task<IEnumerable<Book>> GetBooksUsingStoredProcedureAsync(string procedureName);
}
