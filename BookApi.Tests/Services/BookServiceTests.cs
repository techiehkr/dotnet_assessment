using AutoMapper;
using BookApi.Dtos;
using BookApi.Models;
using BookApi.Repositories;
using BookApi.Services;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace BookApi.Tests.Services
{
    public class BookServiceTests
    {
        private readonly Mock<IBookRepository> _bookRepositoryMock;
        private readonly Mock<IMapper> _mapperMock;
        private readonly Mock<ILogger<BookService>> _loggerMock;
        private readonly BookService _bookService;

        public BookServiceTests()
        {
            _bookRepositoryMock = new Mock<IBookRepository>();
            _mapperMock = new Mock<IMapper>();
            _loggerMock = new Mock<ILogger<BookService>>();
            _bookService = new BookService(_bookRepositoryMock.Object, _mapperMock.Object, _loggerMock.Object);
        }

        [Fact]
        public async Task GetBooksSortedByPublisherAuthorTitleAsync_ReturnsSortedBooks()
        {
            
            var books = new List<Book>
            {
                new Book {  Publisher = "PubA", Title = "How to code", AuthorLastName = "Krishnakumar", AuthorFirstName = "Tharun", Price = 10.0m },
                new Book {  Publisher = "PubB", Title = "How to code1", AuthorLastName = "kumar", AuthorFirstName = "Sudarshan", Price = 20.0m }
            };

            var bookDtos = new List<BookDto>
            {
                new BookDto { Publisher = "PubA", Title = "How to code", AuthorLastName = "Krishnakumar", AuthorFirstName = "Tharun", Price = 10.0m },
                new BookDto {  Publisher = "PubB", Title = "How to code1", AuthorLastName = "kumar", AuthorFirstName = "Sudarshan", Price = 20.0m }
            };

            _bookRepositoryMock.Setup(repo => repo.GetBooksSortedByPublisherAuthorTitleAsync()).ReturnsAsync(books);
            _mapperMock.Setup(mapper => mapper.Map<IEnumerable<BookDto>>(books)).Returns(bookDtos);

            
            var result = await _bookService.GetBooksSortedByPublisherAuthorTitleAsync();

            
            Assert.Equal(bookDtos, result);
        }

        [Fact]
        public async Task GetBooksSortedByAuthorTitleAsync_ReturnsSortedBooks()
        {
            
            var books = new List<Book>
            {
                new Book {  Publisher = "PubA", Title = "How to code", AuthorLastName = "Krishnakumar", AuthorFirstName = "Tharun", Price = 10.0m },
                new Book {  Publisher = "PubB", Title = "How to code1", AuthorLastName = "kumar", AuthorFirstName = "Sudarshan", Price = 20.0m }
            };

            var bookDtos = new List<BookDto>
            {
               new BookDto { Publisher = "PubA", Title = "How to code", AuthorLastName = "Krishnakumar", AuthorFirstName = "Tharun", Price = 10.0m },
                new BookDto {  Publisher = "PubB", Title = "How to code1", AuthorLastName = "kumar", AuthorFirstName = "Sudarshan", Price = 20.0m }
            };

            _bookRepositoryMock.Setup(repo => repo.GetBooksSortedByAuthorTitleAsync()).ReturnsAsync(books);
            _mapperMock.Setup(mapper => mapper.Map<IEnumerable<BookDto>>(books)).Returns(bookDtos);

            
            var result = await _bookService.GetBooksSortedByAuthorTitleAsync();

            
            Assert.Equal(bookDtos, result);
        }

        [Fact]
        public async Task GetTotalPriceAsync_ReturnsTotalPrice()
        {
            
            double totalPrice = 32.98;
            _bookRepositoryMock.Setup(repo => repo.GetTotalPriceAsync()).ReturnsAsync(totalPrice);
            var result = await _bookService.GetTotalPriceAsync();
            Assert.Equal(totalPrice, result);
        }

        [Fact]
        public async Task BulkInsertBooksAsync_InsertsBooks()
        {
            
            var bookDtos = new List<BookDto>
            {
               new BookDto { Publisher = "PubA", Title = "How to code", AuthorLastName = "Krishnakumar", AuthorFirstName = "Tharun", Price = 10.0m },
                new BookDto {  Publisher = "PubB", Title = "How to code1", AuthorLastName = "kumar", AuthorFirstName = "Sudarshan", Price = 20.0m }
            };

            var books = new List<Book>
            {
                new Book {  Publisher = "PubA", Title = "How to code", AuthorLastName = "Krishnakumar", AuthorFirstName = "Tharun", Price = 10.0m },
                new Book {  Publisher = "PubB", Title = "How to code1", AuthorLastName = "kumar", AuthorFirstName = "Sudarshan", Price = 20.0m }
            };

            _mapperMock.Setup(mapper => mapper.Map<IEnumerable<Book>>(bookDtos)).Returns(books);

            
            await _bookService.BulkInsertBooksAsync(bookDtos);

            
            _bookRepositoryMock.Verify(repo => repo.BulkInsertBooksAsync(books), Times.Once);
        }
    }
}
