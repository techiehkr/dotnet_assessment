using BookApi.Dtos;
using BookApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace BookApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BookControllerDto : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookControllerDto(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("publisher-author-title")]
        public async Task<ActionResult<IEnumerable<BookDto>>> GetBooksSortedByPublisherAuthorTitle()
        {
            var books = await _bookService.GetBooksSortedByPublisherAuthorTitleAsync();
            return Ok(books);
        }

        [HttpGet("author-title")]
        public async Task<ActionResult<IEnumerable<BookDto>>> GetBooksSortedByAuthorTitle()
        {
            var books = await _bookService.GetBooksSortedByAuthorTitleAsync();
            return Ok(books);
        }

        [HttpGet("total-price")]
        public async Task<ActionResult<double>> GetTotalPrice()
        {
            var totalPrice = await _bookService.GetTotalPriceAsync();
            return Ok(totalPrice);
        }

        [HttpPost("bulk-insert")]
        public async Task<IActionResult> BulkInsertBooks([FromBody] IEnumerable<BookDto> books)
        {
            await _bookService.BulkInsertBooksAsync(books);
            return Ok();
        }
    }
}
