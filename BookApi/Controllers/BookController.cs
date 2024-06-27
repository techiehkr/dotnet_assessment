using BookApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]

public class BookController : ControllerBase
{
    private readonly IBookRepository _bookRepository;
    

    public BookController(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    [HttpGet("publisher-author-title")]
    public async Task<IActionResult> GetBooksSortedByPublisherAuthorTitle()
    {
        var books = await _bookRepository.GetBooksSortedByPublisherAuthorTitleAsync();
        return Ok(books);
    }

    [HttpGet("author-title")]
    public async Task<IActionResult> GetBooksSortedByAuthorTitle()
    {
        var books = await _bookRepository.GetBooksSortedByAuthorTitleAsync();
        return Ok(books);
    }

    [HttpGet("total-price")]
    public async Task<IActionResult> GetTotalPrice()
    {
        var totalPrice = await _bookRepository.GetTotalPriceAsync();
        return Ok(totalPrice);
    }

    [HttpPost("bulk-insert")]
    public async Task<IActionResult> BulkInsertBooks([FromBody] IEnumerable<Book> books)
    {
        await _bookRepository.BulkInsertBooksAsync(books);
        return Ok();
    }

    [HttpGet("SP-publisher-author-title")]
    public async Task<IActionResult> GetBooksSortedByPublisherAuthorTitleSP()
    {
        var books = await _bookRepository.GetBooksUsingStoredProcedureAsync("GetBooksSortedByPublisherAuthorTitle");
        return Ok(books);
    }

    [HttpGet("SP-author-title")]
    public async Task<IActionResult> GetBooksSortedByAuthorTitleSP()
    {
        var books = await _bookRepository.GetBooksUsingStoredProcedureAsync("GetBooksSortedByAuthorTitle");
        return Ok(books);
    }
}
