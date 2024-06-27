namespace BookApi.Dtos
{
    public class BookDto
    {
        public string Publisher { get; set; } = string.Empty;
        public string Title { get; set; }= string.Empty;
        public string AuthorLastName { get; set; }= string.Empty;
        public string AuthorFirstName { get; set; }= string.Empty;
        public decimal Price { get; set; }
    }
}
